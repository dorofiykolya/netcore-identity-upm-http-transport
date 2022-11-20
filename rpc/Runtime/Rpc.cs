using System;
using System.Collections.Generic;

namespace HttpTransport.Rpc.Identities
{
    public abstract class IdentityRpc
    {
        private HttpTransport.Rpc.IRemoteRequest _remoteRequest;
        protected IdentityRpc(HttpTransport.Rpc.IRemoteRequest request)
        {
            _remoteRequest = request;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.SignInByEmailResponse> Request(global::Identity.Protocol.Rpc.SignInByEmailRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.SignInByEmailResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.SignInByEmailRequest), request, typeof(global::Identity.Protocol.Rpc.SignInByEmailResponse), System.Net.Http.HttpMethod.Post, "/sign/in/email");
            return asyncRequest;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.SignInByGoogleResponse> Request(global::Identity.Protocol.Rpc.SignInByGoogleRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.SignInByGoogleResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.SignInByGoogleRequest), request, typeof(global::Identity.Protocol.Rpc.SignInByGoogleResponse), System.Net.Http.HttpMethod.Post, "/sign/in/google");
            return asyncRequest;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.SignInByGuestResponse> Request(global::Identity.Protocol.Rpc.SignInByGuestRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.SignInByGuestResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.SignInByGuestRequest), request, typeof(global::Identity.Protocol.Rpc.SignInByGuestResponse), System.Net.Http.HttpMethod.Post, "/sign/in/guest");
            return asyncRequest;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.SignOutResponse> Request(global::Identity.Protocol.Rpc.SignOutRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.SignOutResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.SignOutRequest), request, typeof(global::Identity.Protocol.Rpc.SignOutResponse), System.Net.Http.HttpMethod.Post, "/sign/out");
            return asyncRequest;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.SignUpByEmailResponse> Request(global::Identity.Protocol.Rpc.SignUpByEmailRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.SignUpByEmailResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.SignUpByEmailRequest), request, typeof(global::Identity.Protocol.Rpc.SignUpByEmailResponse), System.Net.Http.HttpMethod.Post, "/sign/up/email");
            return asyncRequest;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.SignUpEmailConfirmResponse> Request(global::Identity.Protocol.Rpc.SignUpEmailConfirmRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.SignUpEmailConfirmResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.SignUpEmailConfirmRequest), request, typeof(global::Identity.Protocol.Rpc.SignUpEmailConfirmResponse), System.Net.Http.HttpMethod.Post, "/sign/up/email/confirm");
            return asyncRequest;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.TokenValidateResponse> Request(global::Identity.Protocol.Rpc.TokenValidateRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.TokenValidateResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.TokenValidateRequest), request, typeof(global::Identity.Protocol.Rpc.TokenValidateResponse), System.Net.Http.HttpMethod.Post, "/token/verify");
            return asyncRequest;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.RefreshTokenResponse> Request(global::Identity.Protocol.Rpc.RefreshTokenRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.RefreshTokenResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.RefreshTokenRequest), request, typeof(global::Identity.Protocol.Rpc.RefreshTokenResponse), System.Net.Http.HttpMethod.Post, "/token/refresh");
            return asyncRequest;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.ForgotEmailPasswordResponse> Request(global::Identity.Protocol.Rpc.ForgotEmailPasswordRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.ForgotEmailPasswordResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.ForgotEmailPasswordRequest), request, typeof(global::Identity.Protocol.Rpc.ForgotEmailPasswordResponse), System.Net.Http.HttpMethod.Post, "/user/email/forgot");
            return asyncRequest;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.ChangeEmailPasswordResponse> Request(global::Identity.Protocol.Rpc.ChangeEmailPasswordRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.ChangeEmailPasswordResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.ChangeEmailPasswordRequest), request, typeof(global::Identity.Protocol.Rpc.ChangeEmailPasswordResponse), System.Net.Http.HttpMethod.Post, "/user/email/change");
            return asyncRequest;
        }

        public global::HttpTransport.Rpc.IAsyncResponse<global::Identity.Protocol.Rpc.UserInfoResponse> Request(global::Identity.Protocol.Rpc.UserInfoRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<global::Identity.Protocol.Rpc.UserInfoResponse>();
            _remoteRequest.Request(asyncRequest, typeof(global::Identity.Protocol.Rpc.UserInfoRequest), request, typeof(global::Identity.Protocol.Rpc.UserInfoResponse), System.Net.Http.HttpMethod.Post, "/user/info");
            return asyncRequest;
        }
    }
}