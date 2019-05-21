
# Client (curl)

## Author
#### GET REQUEST (ALL)
```bash
curl -X GET -v http://localhost:50019/api/author/all
```

#### GET REQUEST (BY ID)
```bash
curl -X GET -v http://localhost:50019/api/author/id/1
```

#### POST REQUEST
```bash
curl -v -X POST -H "Content-type: application/json" -d "{\"AuthorAge\":30,\"AuthorName\":\"Alice\",\"AuthorImage\":\"Alice.jpeg\"}" http://localhost:50019/api/author 
```
#### PUT REQUEST

```bash
curl -v -X PUT -H "Content-type: application/json" -d "{\"AuthorAge\":21,\"AuthorName\":\"Tom\",\"AuthorImage\":\"Tom.jpeg\"}" http://localhost:50019/api/author/id/1
```

#### DELETE REQUEST

```bash
curl -v -X DELETE http://localhost:50019/api/author/id/1
```



## Book
#### GET REQUEST (ALL)
```bash
curl -X GET -v http://localhost:50019/api/book/all
```

#### GET REQUEST (BY ID)
```bash
curl -X GET -v http://localhost:50019/api/book/id/1
```

#### POST REQUEST

```bash
curl -v -X POST -H "Content-type: application/json" -d "{\"BookName\":\"History\",\"BookPrice\":90,\"BookAuthor\":{\"AuthorAge\":30,\"AuthorName\":\"Alice\",\"AuthorImage\":\"Alice.jpeg\"}}" http://localhost:50019/api/book 
```
#### PUT REQUEST

```bash
curl -v -X PUT -H "Content-type: application/json" -d "{\"BookName\":\"Test\",\"BookPrice\":90,\"BookAuthor\":{\"AuthorAge\":30,\"AuthorName\":\"Alice\",\"AuthorImage\":\"Alice.jpeg\"}}" http://localhost:50019/api/book/id/2
```

#### DELETE REQUEST

```bash
curl -v -X DELETE http://localhost:50019/api/book/id/1
```
