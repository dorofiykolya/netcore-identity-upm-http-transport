using System;
using System.Collections.Generic;

namespace Game.Rpc
{
    public abstract class RpcBase
    {
        private HttpTransport.Rpc.IRemoteRequest _remoteRequest;
        protected RpcBase(HttpTransport.Rpc.IRemoteRequest request)
        {
            _remoteRequest = request;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.SignInByEmailResponse> Request(Identity.Protocol.Rpc.SignInByEmailRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.SignInByEmailResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.SignInByEmailRequest), request, typeof(Identity.Protocol.Rpc.SignInByEmailResponse), System.Net.Http.HttpMethod.Post, "/sign/in/email");
            return asyncRequest;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.SignInByGoogleResponse> Request(Identity.Protocol.Rpc.SignInByGoogleRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.SignInByGoogleResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.SignInByGoogleRequest), request, typeof(Identity.Protocol.Rpc.SignInByGoogleResponse), System.Net.Http.HttpMethod.Post, "/sign/in/google");
            return asyncRequest;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.SignInByGuestResponse> Request(Identity.Protocol.Rpc.SignInByGuestRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.SignInByGuestResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.SignInByGuestRequest), request, typeof(Identity.Protocol.Rpc.SignInByGuestResponse), System.Net.Http.HttpMethod.Post, "/sign/in/guest");
            return asyncRequest;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.SignOutResponse> Request(Identity.Protocol.Rpc.SignOutRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.SignOutResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.SignOutRequest), request, typeof(Identity.Protocol.Rpc.SignOutResponse), System.Net.Http.HttpMethod.Post, "/sign/out");
            return asyncRequest;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.SignUpByEmailResponse> Request(Identity.Protocol.Rpc.SignUpByEmailRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.SignUpByEmailResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.SignUpByEmailRequest), request, typeof(Identity.Protocol.Rpc.SignUpByEmailResponse), System.Net.Http.HttpMethod.Post, "/sign/up/email");
            return asyncRequest;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.SignUpEmailConfirmResponse> Request(Identity.Protocol.Rpc.SignUpEmailConfirmRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.SignUpEmailConfirmResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.SignUpEmailConfirmRequest), request, typeof(Identity.Protocol.Rpc.SignUpEmailConfirmResponse), System.Net.Http.HttpMethod.Post, "/sign/up/email/confirm");
            return asyncRequest;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.TokenValidateResponse> Request(Identity.Protocol.Rpc.TokenValidateRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.TokenValidateResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.TokenValidateRequest), request, typeof(Identity.Protocol.Rpc.TokenValidateResponse), System.Net.Http.HttpMethod.Post, "/token/validate");
            return asyncRequest;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.RefreshTokenResponse> Request(Identity.Protocol.Rpc.RefreshTokenRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.RefreshTokenResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.RefreshTokenRequest), request, typeof(Identity.Protocol.Rpc.RefreshTokenResponse), System.Net.Http.HttpMethod.Post, "/token/refresh");
            return asyncRequest;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.ForgotEmailPasswordResponse> Request(Identity.Protocol.Rpc.ForgotEmailPasswordRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.ForgotEmailPasswordResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.ForgotEmailPasswordRequest), request, typeof(Identity.Protocol.Rpc.ForgotEmailPasswordResponse), System.Net.Http.HttpMethod.Post, "/user/email/forgot");
            return asyncRequest;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.ChangeEmailPasswordResponse> Request(Identity.Protocol.Rpc.ChangeEmailPasswordRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.ChangeEmailPasswordResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.ChangeEmailPasswordRequest), request, typeof(Identity.Protocol.Rpc.ChangeEmailPasswordResponse), System.Net.Http.HttpMethod.Post, "/user/email/change");
            return asyncRequest;
        }

        public HttpTransport.Rpc.IAsyncResponse<Identity.Protocol.Rpc.UserInfoResponse> Request(Identity.Protocol.Rpc.UserInfoRequest request)
        {
            var asyncRequest = new HttpTransport.Rpc.AsyncResponse<Identity.Protocol.Rpc.UserInfoResponse>();
            _remoteRequest.Request(asyncRequest, typeof(Identity.Protocol.Rpc.UserInfoRequest), request, typeof(Identity.Protocol.Rpc.UserInfoResponse), System.Net.Http.HttpMethod.Post, "/user/info");
            return asyncRequest;
        }
    }
}