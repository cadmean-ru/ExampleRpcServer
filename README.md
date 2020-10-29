# Example cadRPC server

This is an ASP.NET Core based cadRPC server intended for 
testing and demonstrating of the technology.

This server is running at [http://testrpc.cadmean.ru](http://testrpc.cadmean.ru).
However it is not guaranteed, that the server will be maintained.

### Running in Docker container

You can run this server yourself in a Docker container:

```
docker run -d -p 80:80 cadrealm/cadrpcexampleserver
```

### Available functions

| Name                | Arguments               | Return value           | Description                                                                    |
| ------------------- | ----------------------- | ---------------------- | ------------------------------------------------------------------------------ |
| auth                | email, password: String | JwtAuthorizationTicket | Authorizes user with email and password, so then authorized calls can be made. |
| concat              | s1, s2, s3: String      | String                 | Returns concatenated string of the 3 string arguments                          |
| getDate             |                         | Date                   | Returns current date                                                           |
| user.get            |                         | User {email, name}     | Returns user info if authorized                                                |
| square              | d: Double               | Double                 | Calculates d^2                                                                 |
| sum                 | a, b: Integer           | Integer                | Calculates sun of two integer numbers                                          |
| weatherForecast.get |                         | WeatherForecast        | Returns a WeatherForecast object                                               |

### See also

* [C# client and server libraries](https://github.com/cadmean-ru/Cadmean.RPC)
* [Python client library](https://github.com/cadmean-ru/pythonRPCKit)