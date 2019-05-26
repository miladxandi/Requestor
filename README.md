![Requestor](https://eastcloud.ir/Content/Shared/Libraries/Requestor.png)
# Requestor

## Send GET http request:
### Use this method to send it:
> var Response = Maker.Request(HOST,"get");

### Reponse:
`Reponse` is a simple string.

## To send a form with POST or any other method:

### Make a dictionary same as your form:
>Dictionary<string, string> Dict = new Dictionary<string, string>();
>Dict.Add(Key,Value);

### Then use this method to send it:
>var Response = Task.Run(() => Maker.RequestAsync(HOST, Dict));

### Reponse:
`Response.Result` will be a simple string.

#### `UWP` only supports get method at this version.

### Installation on UWP or .NET Core
Maybe you could not find the package after getting it from nuget.org, then you need to change this line of code of the `projects.assets.json` file after a successful installation of the library in `\obj` folder:
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