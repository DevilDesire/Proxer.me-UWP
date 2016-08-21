using ProxerMeApi.Implementation.SpezifischeExceptions;
using ProxerMeApi.Interfaces.ExceptionHandler;

namespace ProxerMeApi.Implementation.Handler
{
    public class ExceptionHandler : IExceptionHandler
    {
        public void CheckForCaptcha(string message)
        {
            if (message.Contains("captcha"))
            {
                throw new CaptchaException("http://proxer.me/misc/captcha");
            }
        }
    }
}