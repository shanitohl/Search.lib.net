using Search.lib.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.lib.test
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchProvider of = new SearchProvider();
            OpenFact.RefreshTokenModel oRefreshToken = new OpenFact.RefreshTokenModel();
            TokenModel oTokenModel = new TokenModel();
            string clientId = "openfact-web-console";
            oTokenModel.refreshToken = "eyJhbGciOiJSUzI1NiIsInR5cCIgOiAiSldUIiwia2lkIiA6ICJGSjg2R2NGM2pUYk5MT2NvNE52WmtVQ0lVbWZZQ3FvcXRPUWVNZmJoTmxFIn0.eyJqdGkiOiIwNjQ1NTVmNi03ZWY2LTQwOWUtODliZC04NzRkMmM2NDBiYzIiLCJleHAiOjAsIm5iZiI6MCwiaWF0IjoxNTI5MzU3ODczLCJpc3MiOiJodHRwOi8va2V5Y2xvYWsta2V5Y2xvYWstc3NvLWRldmVsb3BtZW50LmFwcHMuY29uc29sZS5zaXN0Y29vcC5vcmcvYXV0aC9yZWFsbXMvYWhyZW4iLCJhdWQiOiJvcGVuZmFjdC13ZWItY29uc29sZSIsInN1YiI6IjY5YTU1MjU2LTA5YzMtNGI0Yy04MjNlLTUzMGMzYjJiZmE5OSIsInR5cCI6Ik9mZmxpbmUiLCJhenAiOiJvcGVuZmFjdC13ZWItY29uc29sZSIsIm5vbmNlIjoiNjYzZWZlZjktMjYxYy00NTVkLWE0MGUtYmI5NDkxZmRlMjQ1IiwiYXV0aF90aW1lIjowLCJzZXNzaW9uX3N0YXRlIjoiNzhmMzMwNzYtM2EwOS00OTk5LTlmN2ItYTc5YTJiYzcxYWM5IiwiY2xpZW50X3Nlc3Npb24iOiI1OTcyMWNlMS05OTVkLTRjNDItYWI4Zi00ZTA3N2ZhZGZhZmYiLCJyZWFsbV9hY2Nlc3MiOnsicm9sZXMiOlsib3JnYW5pemF0aW9uLW1hbmFnZXIiLCJvZmZsaW5lX2FjY2VzcyIsImFkbWluIiwib3JnYW5pemF0aW9uLXVzZXIiLCJ1bWFfYXV0aG9yaXphdGlvbiJdfSwicmVzb3VyY2VfYWNjZXNzIjp7Im9wZW5mYWN0Ijp7InJvbGVzIjpbIm1hbmFnZS1ldmVudHMiLCJtYW5hZ2Utb3JnYW5pemF0aW9uIiwidmlldy1ldmVudHMiLCJ2aWV3LWRvY3VtZW50cyIsImNyZWF0ZS1vcmdhbml6YXRpb24iLCJtYW5hZ2UtZG9jdW1lbnRzIiwidmlldy1vcmdhbml6YXRpb24iXX0sImFjY291bnQiOnsicm9sZXMiOlsibWFuYWdlLWFjY291bnQiLCJtYW5hZ2UtYWNjb3VudC1saW5rcyIsInZpZXctcHJvZmlsZSJdfX19.YlUEofqgbxjcfrQF2WsoHDVCOUJUtbs6lzRpDAlipG6GG6x6wTHdlmHohgcZCy0kCJ3pKf4QNSCJg81xjM6abboPVu0nV-LS9iXksGlG0Rlwg5SwmgOkjk3G1ff7eqO7DH7tyFeEcODQ4Qmmh1YrjjBipxcbBR3jWqZrLszWdfg";
            //oTokenModel = _serviceGeneric.GetTokenEmpresa(realm);
            oRefreshToken = of.RefreshToken(oTokenModel.refreshToken, "http://keycloak-keycloak-sso-development.apps.console.sistcoop.org/auth/realms/ahren", clientId);
            var representation = of.getInvoiceById(oRefreshToken.access_token, "http://openfactv2-openfact-development.apps.console.sistcoop.org/api/admin/organizations/ahren", "dbee4a0f-a50b-4fdf-867b-e6d1eb0fb11d");
        }
    }
}
