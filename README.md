# ConnectD365ByCDSServiceClient
    SDK is alpha version.
    Only support 3 authorize types(certificates, oauth, clientsecret).

* OAuth
    - For development and prototype, use the clientid and redirecturi in source code. Then set username(user in dynamics with license assigned.), password, url, and authtype equals "OAuth".
    - For production, need to create a OAuth flow to get clientid and rediecturi. (TBC)

* ClientSecret
    - Regist an app in azure active directory first, and then get the clientid(appid).
    - Add a client secret in Certificates & secret, get the clientsecret.
    - Add a user in azure active directory.
    - add this user by username and clientid to Dynamics 365 application user. 
    - set connectionstring with clientid and clientsecret, url, and authtype equals "clientsecret".
