onload = getProducts;

function getProducts() {

    document.getElementById("productList").innerHTML = "";

    fetch("/api/product")
        .then(res => res.json())
        .then(productList => {
            for (let i = 0; i < productList.length; i++) {
                let product = productList[i];

                document.getElementById("productList").innerHTML += `
                        <div class="col-sm-4">
                            <div class ="thumbnail" title="${product.id}">
                            <input disabled value="${product.id}" id="${product.id}id"/>
                            <input disabled value="${product.name}" id="${product.id}name"/>
                            <input disabled value="$ ${product.price}" id="${product.id}price"/>
                            <button class="btn" id="${product.id}edit">Edit</button>
                            <button class="btn" id="${product.id}delete">Delete</button>
                            <button style="display:none" class="btn" id="${product.id}save">Save changes</button>
                            </div>
                        </div>`;

            }


            for (let i = 0; i < productList.length; i++) {
                let product = productList[i];

                document.getElementById(product.id + "edit")
                .addEventListener("click", () => { editProduct(product) });

                document.getElementById(product.id + "delete")
                .addEventListener("click", () => { deleteProduct(product.id) });

                document.getElementById(product.id + "save")
                .addEventListener("click", () => { saveChanges(product) });
            }
        })
        .catch(err => console.log(err));
}

function deleteProduct(id) {
    fetch("/api/product/" + id, { method: "DELETE" })
    .then(res => getProducts())
    .catch(err => console.log(err));
}



function addProduct() {

    let body = {
        "name": document.getElementById("newname").value,
        "price": document.getElementById("newprice").value,
        "id": document.getElementById("newpid").value
    };

    document.getElementById("newpid").value = "";
    document.getElementById("newname").value = "";
    document.getElementById("newprice").value = "";

    fetch("/api/product", {
        method: "POST",
        headers: {
            "Content-Type": "application/json; charset=utf-8",
        },
        body: JSON.stringify(body),
    })
    .then(res => getProducts())
    .catch(err => console.log(err));

}


function saveChanges(product) {

    document.getElementById(product.id + "name").setAttribute("disabled", true);
    document.getElementById(product.id + "price").setAttribute("disabled", true);
    document.getElementById(product.id + "save").style.display = "none";

    let body = {
        "name": document.getElementById(product.id + "name").value,
        "price": document.getElementById(product.id + "price").value
    };


    fetch("/api/product/" + product.id, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json; charset=utf-8",
        },
        body: JSON.stringify(body),
    })
    .then(res => getProducts())
    .catch(err => console.log(err));
}


function editProduct(product) {
    document.getElementById(product.id + "save").style.display = "block";
    document.getElementById(product.id + "name").removeAttribute("disabled");
    document.getElementById(product.id + "price").removeAttribute("disabled");
}
