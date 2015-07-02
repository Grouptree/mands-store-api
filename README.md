# M&S Store API class

## Usage

```
var client = new MandsStoreApiClient("my api key", "my api secret");
var store = await client.GetStoreInfo("10");
```

## Tests

In order to run the tests, include a file called `localsettings.config` in the
Test project containing the API keys and configure Visual Studio to copy it
over to the build folder.

Please remember not to commit the API secrets into source control.
