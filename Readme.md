```bash
#To create a new project with dotnet and azure function

#Install the azure fucntion core tools

npm install -g azure-functions-core-tools  

## If using Dotnet 8

npm install -g azure-functions-core-tools@4


#Create a Function APP

func init SimplyTheBest --worker-runtime dotnet


#Navigate to Function APP

cd SimplyTheBest

#Create a new Azure Function

func new

#Choose the one you like and let's play

#To start the azure function 

func start
```