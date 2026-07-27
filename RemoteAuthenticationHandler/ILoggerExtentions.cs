using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.Logging
{
    public static class LoggingExtensions
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __UpdatingConfigurationCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(13, "UpdatingConfiguration"), "Updating configuration", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void UpdatingConfiguration(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __UpdatingConfigurationCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __ConfigurationManagerRequestRefreshCalledCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(18, "ConfigurationManagerRequestRefreshCalled"), "Exception of type 'SecurityTokenSignatureKeyNotFoundException' thrown, Options.ConfigurationManager.RequestRefresh() called.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void ConfigurationManagerRequestRefreshCalled(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __ConfigurationManagerRequestRefreshCalledCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __AuthorizationCodeReceivedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(27, "AuthorizationCodeReceived"), "Authorization code received.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void AuthorizationCodeReceived(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __AuthorizationCodeReceivedCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __TokenResponseReceivedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(30, "TokenResponseReceived"), "Token response received.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void TokenResponseReceived(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __TokenResponseReceivedCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __ReceivedIdTokenCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(21, "ReceivedIdToken"), "Received 'id_token'", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void ReceivedIdToken(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __ReceivedIdTokenCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RedeemingCodeForTokensCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(19, "RedeemingCodeForTokens"), "Redeeming code for tokens.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RedeemingCodeForTokens(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __RedeemingCodeForTokensCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __TokenValidatedHandledResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(15, "TokenValidatedHandledResponse"), "TokenValidated.HandledResponse", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void TokenValidatedHandledResponse(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __TokenValidatedHandledResponseCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __TokenValidatedSkippedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(16, "TokenValidatedSkipped"), "TokenValidated.Skipped", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void TokenValidatedSkipped(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __TokenValidatedSkippedCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __AuthorizationCodeReceivedContextHandledResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(28, "AuthorizationCodeReceivedContextHandledResponse"), "AuthorizationCodeReceivedContext.HandledResponse", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void AuthorizationCodeReceivedContextHandledResponse(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __AuthorizationCodeReceivedContextHandledResponseCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __AuthorizationCodeReceivedContextSkippedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(29, "AuthorizationCodeReceivedContextSkipped"), "AuthorizationCodeReceivedContext.Skipped", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void AuthorizationCodeReceivedContextSkipped(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __AuthorizationCodeReceivedContextSkippedCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __TokenResponseReceivedHandledResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(31, "TokenResponseReceivedHandledResponse"), "TokenResponseReceived.HandledResponse", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void TokenResponseReceivedHandledResponse(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __TokenResponseReceivedHandledResponseCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __TokenResponseReceivedSkippedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(32, "TokenResponseReceivedSkipped"), "TokenResponseReceived.Skipped", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void TokenResponseReceivedSkipped(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __TokenResponseReceivedSkippedCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __AuthenticationFailedContextHandledResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(38, "AuthenticationFailedContextHandledResponse"), "AuthenticationFailedContext.HandledResponse", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void AuthenticationFailedContextHandledResponse(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __AuthenticationFailedContextHandledResponseCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __AuthenticationFailedContextSkippedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(39, "AuthenticationFailedContextSkipped"), "AuthenticationFailedContext.Skipped", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void AuthenticationFailedContextSkipped(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __AuthenticationFailedContextSkippedCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __MessageReceivedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(24, "MessageReceived"), "MessageReceived: '{RedirectUrl}'.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void MessageReceived(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String redirectUrl)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __MessageReceivedCallback(logger, redirectUrl, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __MessageReceivedContextHandledResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(25, "MessageReceivedContextHandledResponse"), "MessageReceivedContext.HandledResponse", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void MessageReceivedContextHandledResponse(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __MessageReceivedContextHandledResponseCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __MessageReceivedContextSkippedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(26, "MessageReceivedContextSkipped"), "MessageReceivedContext.Skipped", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void MessageReceivedContextSkipped(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __MessageReceivedContextSkippedCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RedirectToIdentityProviderForSignOutHandledResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(1, "RedirectToIdentityProviderForSignOutHandledResponse"), "RedirectToIdentityProviderForSignOut.HandledResponse", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RedirectToIdentityProviderForSignOutHandledResponse(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __RedirectToIdentityProviderForSignOutHandledResponseCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RedirectToIdentityProviderHandledResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(6, "RedirectToIdentityProviderHandledResponse"), "RedirectToIdentityProvider.HandledResponse", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RedirectToIdentityProviderHandledResponse(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __RedirectToIdentityProviderHandledResponseCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __SignOutCallbackRedirectHandledResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(50, "SignOutCallbackRedirectHandledResponse"), "RedirectToSignedOutRedirectUri.HandledResponse", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void SignOutCallbackRedirectHandledResponse(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __SignOutCallbackRedirectHandledResponseCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __SignOutCallbackRedirectSkippedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(51, "SignOutCallbackRedirectSkipped"), "RedirectToSignedOutRedirectUri.Skipped", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void SignOutCallbackRedirectSkipped(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __SignOutCallbackRedirectSkippedCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __UserInformationReceivedHandledResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(36, "UserInformationReceivedHandledResponse"), "The UserInformationReceived event returned Handled.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void UserInformationReceivedHandledResponse(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __UserInformationReceivedHandledResponseCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __UserInformationReceivedSkippedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(37, "UserInformationReceivedSkipped"), "The UserInformationReceived event returned Skipped.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void UserInformationReceivedSkipped(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __UserInformationReceivedSkippedCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __PushAuthorizationHandledClientAuthenticationCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(57, "PushAuthorizationHandledClientAuthentication"), "The PushAuthorization event handled client authentication", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void PushAuthorizationHandledClientAuthentication(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __PushAuthorizationHandledClientAuthenticationCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __PushAuthorizationHandledPushCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(58, "PushAuthorizationHandledPush"), "The PushAuthorization event handled pushing authorization", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void PushAuthorizationHandledPush(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __PushAuthorizationHandledPushCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __PushAuthorizationSkippedPushCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(59, "PushAuthorizationSkippedPush"), "The PushAuthorization event skipped pushing authorization", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void PushAuthorizationSkippedPush(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __PushAuthorizationSkippedPushCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __InvalidLogoutQueryStringRedirectUrlCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Warning, new global::Microsoft.Extensions.Logging.EventId(3, "InvalidLogoutQueryStringRedirectUrl"), "The query string for Logout is not a well-formed URI. Redirect URI: '{RedirectUrl}'.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void InvalidLogoutQueryStringRedirectUrl(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String redirectUrl)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                __InvalidLogoutQueryStringRedirectUrlCallback(logger, redirectUrl, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __NullOrEmptyAuthorizationResponseStateCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(10, "NullOrEmptyAuthorizationResponseState"), "message.State is null or empty.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void NullOrEmptyAuthorizationResponseState(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __NullOrEmptyAuthorizationResponseStateCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __UnableToReadAuthorizationResponseStateCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(11, "UnableToReadAuthorizationResponseState"), "Unable to read the message.State.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void UnableToReadAuthorizationResponseState(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __UnableToReadAuthorizationResponseStateCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.String, global::System.String, global::System.Exception?> __ResponseErrorCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String, global::System.String, global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(12, "ResponseError"), "Message contains error: '{Error}', error_description: '{ErrorDescription}', error_uri: '{ErrorUri}'.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void ResponseError(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String error, global::System.String errorDescription, global::System.String errorUri)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __ResponseErrorCallback(logger, error, errorDescription, errorUri, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.String, global::System.String, global::System.Int32, global::System.Exception?> __ResponseErrorWithStatusCodeCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String, global::System.String, global::System.String, global::System.Int32>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(52, "ResponseErrorWithStatusCode"), "Message contains error: '{Error}', error_description: '{ErrorDescription}', error_uri: '{ErrorUri}', status code '{StatusCode}'.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void ResponseErrorWithStatusCode(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String error, global::System.String errorDescription, global::System.String errorUri, global::System.Int32 statusCode)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __ResponseErrorWithStatusCodeCallback(logger, error, errorDescription, errorUri, statusCode, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __ExceptionProcessingMessageCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(17, "ExceptionProcessingMessage"), "Exception occurred while processing message.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void ExceptionProcessingMessage(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.Exception ex)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __ExceptionProcessingMessageCallback(logger, ex);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __AccessTokenNotAvailableCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(42, "AccessTokenNotAvailable"), "The access_token is not available. Claims cannot be retrieved.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void AccessTokenNotAvailable(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __AccessTokenNotAvailableCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RetrievingClaimsCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(20, "RetrievingClaims"), "Retrieving claims from the user info endpoint.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RetrievingClaims(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __RetrievingClaimsCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __UserInfoEndpointNotSetCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(22, "UserInfoEndpointNotSet"), "UserInfoEndpoint is not set. Claims cannot be retrieved.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void UserInfoEndpointNotSet(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __UserInfoEndpointNotSetCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __UnableToProtectNonceCookieCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Warning, new global::Microsoft.Extensions.Logging.EventId(23, "UnableToProtectNonceCookie"), "Failed to un-protect the nonce cookie.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void UnableToProtectNonceCookie(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.Exception ex)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                __UnableToProtectNonceCookieCallback(logger, ex);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __InvalidAuthenticationRequestUrlCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Warning, new global::Microsoft.Extensions.Logging.EventId(8, "InvalidAuthenticationRequestUrl"), "The redirect URI is not well-formed. The URI is: '{AuthenticationRequestUrl}'.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void InvalidAuthenticationRequestUrl(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String authenticationRequestUrl)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                __InvalidAuthenticationRequestUrlCallback(logger, authenticationRequestUrl, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __UnableToReadIdTokenCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(43, "UnableToReadIdToken"), "Unable to read the 'id_token', no suitable ISecurityTokenValidator was found for: '{IdToken}'.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void UnableToReadIdToken(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String idToken)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __UnableToReadIdTokenCallback(logger, idToken, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String?, global::System.Exception?> __InvalidSecurityTokenTypeCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String?>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(40, "InvalidSecurityTokenType"), "The Validated Security Token must be of type JwtSecurityToken, but instead its type is: '{SecurityTokenType}'", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void InvalidSecurityTokenType(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String? securityTokenType)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __InvalidSecurityTokenTypeCallback(logger, securityTokenType, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __UnableToValidateIdTokenCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(41, "UnableToValidateIdToken"), "Unable to validate the 'id_token', no suitable ISecurityTokenValidator was found for: '{IdToken}'.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void UnableToValidateIdToken(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String idToken)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __UnableToValidateIdTokenCallback(logger, idToken, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __EnteringOpenIdAuthenticationHandlerHandleRemoteAuthenticateAsyncCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(9, "EnteringOpenIdAuthenticationHandlerHandleRemoteAuthenticateAsync"), "Entering {OpenIdConnectHandlerType}'s HandleRemoteAuthenticateAsync.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void EnteringOpenIdAuthenticationHandlerHandleRemoteAuthenticateAsync(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String openIdConnectHandlerType)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __EnteringOpenIdAuthenticationHandlerHandleRemoteAuthenticateAsyncCallback(logger, openIdConnectHandlerType, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __EnteringOpenIdAuthenticationHandlerHandleUnauthorizedAsyncCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(4, "EnteringOpenIdAuthenticationHandlerHandleUnauthorizedAsync"), "Entering {OpenIdConnectHandlerType}'s HandleUnauthorizedAsync.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void EnteringOpenIdAuthenticationHandlerHandleUnauthorizedAsync(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String openIdConnectHandlerType)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __EnteringOpenIdAuthenticationHandlerHandleUnauthorizedAsyncCallback(logger, openIdConnectHandlerType, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __EnteringOpenIdAuthenticationHandlerHandleSignOutAsyncCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(14, "EnteringOpenIdAuthenticationHandlerHandleSignOutAsync"), "Entering {OpenIdConnectHandlerType}'s HandleSignOutAsync.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void EnteringOpenIdAuthenticationHandlerHandleSignOutAsync(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String openIdConnectHandlerType)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __EnteringOpenIdAuthenticationHandlerHandleSignOutAsyncCallback(logger, openIdConnectHandlerType, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __UserInformationReceivedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(35, "UserInformationReceived"), "User information received: {User}", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void UserInformationReceived(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String user)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __UserInformationReceivedCallback(logger, user, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __PostAuthenticationLocalRedirectCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(5, "PostAuthenticationLocalRedirect"), "Using properties.RedirectUri for 'local redirect' post authentication: '{RedirectUri}'.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void PostAuthenticationLocalRedirect(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String redirectUri)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __PostAuthenticationLocalRedirectCallback(logger, redirectUri, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __PostSignOutRedirectCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(33, "PostSignOutRedirect"), "Using properties.RedirectUri for redirect post authentication: '{RedirectUri}'.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void PostSignOutRedirect(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String redirectUri)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __PostSignOutRedirectCallback(logger, redirectUri, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RemoteSignOutHandledResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(44, "RemoteSignOutHandledResponse"), "RemoteSignOutContext.HandledResponse", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RemoteSignOutHandledResponse(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __RemoteSignOutHandledResponseCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RemoteSignOutSkippedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(45, "RemoteSignOutSkipped"), "RemoteSignOutContext.Skipped", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RemoteSignOutSkipped(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __RemoteSignOutSkippedCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RemoteSignOutCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Information, new global::Microsoft.Extensions.Logging.EventId(46, "RemoteSignOut"), "Remote signout request processed.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RemoteSignOut(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Information))
            {
                __RemoteSignOutCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RemoteSignOutSessionIdMissingCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(47, "RemoteSignOutSessionIdMissing"), "The remote signout request was ignored because the 'sid' parameter was missing, which may indicate an unsolicited logout.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RemoteSignOutSessionIdMissing(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __RemoteSignOutSessionIdMissingCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RemoteSignOutSessionIdInvalidCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(48, "RemoteSignOutSessionIdInvalid"), "The remote signout request was ignored because the 'sid' parameter didn't match the expected value, which may indicate an unsolicited logout.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RemoteSignOutSessionIdInvalid(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __RemoteSignOutSessionIdInvalidCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __AuthenticationSchemeSignedOutCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Information, new global::Microsoft.Extensions.Logging.EventId(49, "AuthenticationSchemeSignedOut"), "AuthenticationScheme: {AuthenticationScheme} signed out.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void AuthenticationSchemeSignedOut(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String authenticationScheme)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Information))
            {
                __AuthenticationSchemeSignedOutCallback(logger, authenticationScheme, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.String, global::System.Exception?> __HandleChallengeCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String, global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(53, "HandleChallenge"), "HandleChallenge with Location: {Location}; and Set-Cookie: {Cookie}.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void HandleChallenge(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String location, global::System.String cookie)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __HandleChallengeCallback(logger, location, cookie, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RemoteSignOutIssuerMissingCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(54, "RemoteSignOutIssuerMissing"), "The remote signout request was ignored because the 'iss' parameter was missing, which may indicate an unsolicited logout.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RemoteSignOutIssuerMissing(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __RemoteSignOutIssuerMissingCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __RemoteSignOutIssuerInvalidCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(55, "RemoteSignOutIssuerInvalid"), "The remote signout request was ignored because the 'iss' parameter didn't match the expected value, which may indicate an unsolicited logout.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void RemoteSignOutIssuerInvalid(this global::Microsoft.Extensions.Logging.ILogger logger)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __RemoteSignOutIssuerInvalidCallback(logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.Exception?> __UnableToValidateIdTokenFromHandlerCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(56, "UnableToValidateIdTokenFromHandler"), "Unable to validate the 'id_token', no suitable TokenHandler was found for: '{IdToken}'.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void UnableToValidateIdTokenFromHandler(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.String idToken)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __UnableToValidateIdTokenFromHandlerCallback(logger, idToken, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Type?, global::System.Exception?> __InvalidSecurityTokenTypeFromHandlerCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.Type?>(global::Microsoft.Extensions.Logging.LogLevel.Error, new global::Microsoft.Extensions.Logging.EventId(57, "InvalidSecurityTokenTypeFromHandler"), "The Validated Security Token must be of type JsonWebToken, but instead its type is: '{SecurityTokenType}.'", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true });

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "10.0.14.32716")]
        public static void InvalidSecurityTokenTypeFromHandler(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.Type? securityTokenType)
        {
            if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
            {
                __InvalidSecurityTokenTypeFromHandlerCallback(logger, securityTokenType, null);
            }
        }
    }
}