# Python template

this template is used to create a Python function in function factory serverless environment

## Event

event object is passed to function from workspace or serverless provider. here is a the schema of event:

```json
{
  "body": "request body object or string - only in http calls",
  "headers": "request headers as a key value objcet - only in http calls",
  "params": "query parameters as a key value object - only in http calls",
  "message": "message string - in websocket, queue and non-http calls"
}
```

here is an example call for an http call:

```json
{
  "body": {
    "key1": "string value",
    "key2": ["array value 1", "array value 2"],
    "key3": {
      "subkey1": "sub string value 1"
    }
  },
  "headers": {
    "authorization": "Bearer [token]"
  },
  "params": {
    "key1": "value1",
    "key2": "value2"
  }
}
```

and another example for a non-http call:

```json
{
  "message": "some message from another service"
}
```

## Response

function response is an object with two primary keys: `statusCode` and `body`, status code is practicing the http status code. for instance: 200 means successfull and 500 means internal/unkown error

here is an example response payload for it:

for successful responses

```json
{
  "statusCode": 200,
  "body": "a successful response"
}
```

for failures

```json
{
  "statusCode": 500,
  "body": "something went wrong"
}
```

body value can be also json stringified for http response usage, for example:

for http calls

```json
{
  "statusCode": 200,
  "body": "{\"foo\": \"bar\"}"
}
```
