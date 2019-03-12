![Requestor](https://eastcloud.ir/Content/Shared/Libraries/Requestor.png)
# Requestor
## Make a request
After instantiating a new instance, use this code:
`oMake.Request(https://mildzandi.ir/api,GET);`

## Get the response
Now this method will give you the `Response` as `string` to work on it as `Json` or anything else.

### Installation on UWP or .NET Core
Maybe you could not find the package after getting it from nuget.org, then you need to change this line of code of the `projects.assets.json` file after a successfully installation of library in `\obj` folder:
```
"HttpRequestor/1.2.0": {
        "type": "package",
        "compile": {
          "lib/netcoreapp2.1/_._": {}
        },
        "runtime": {
          "lib/netcoreapp2.1/Requestor.dll": {}
        }
},
```

To this:
```
"HttpRequestor/1.2.0": {
        "type": "package",
        "compile": {
          "lib/netcoreapp2.1/Requestor.dll": {}
        },
        "runtime": {
          "lib/netcoreapp2.1/Requestor.dll": {}
        }
},
```