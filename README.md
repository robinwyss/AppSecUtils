# AppSec Utils
CLI to query the Dynatrace API and get a list of entities with the corresponding vulnerabilities. 
## Usage 

```
-e, --env         Required. Endpoint of the Dynatrace API

-t, --token       Required. Dynatrace API token

-g, --grouping    (Default: Library) Group vulberarbilites by entity (possible values Library, Application, Service,
                Host)

--help            Display this help screen.

--version         Display version information.
  ```
Example to get all libraries with the detected vulnerabilities:
`-e https://xxxxxxxx.live.dynatrace.com -t dt0c01.XXXXX -g Library`