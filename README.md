## Virtual triangle object Example c# program 

### Template
- **c# command line** template generated with command 
```sh
dotnet new console
``` 
dotnet program allow us to run and generate template

```sh                
Triangle             # root directory
│  
├─ .git/             # git files
├─ .gitignore        # /
│  
├─ .vscode/          # build/debug config
│  
├─ obj/              # it seem configuration auto generated
├─ bin/              # /
│  
├─ build/            # my build directory
│  
├─ README.md          
│  
├─ Triangle.csproj   # configuration?
│  
└─ src
   ├─ program.cs     # source code
   └─ triangle.cs    # /

```

[click here to find more about it](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new)


### Getting started
run this command in the root directory
```sh
dotnet build -o Build Triangle.csproj
./Build/Triangle
```


### Contributors
- [Andera Favretto](https://google.com)
