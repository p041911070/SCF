﻿using Senparc.Service;
using Senparc.Scf.Core.Cache;
using Senparc.Scf.Service;

namespace Senparc.Mvc.Controllers
{
    public class LoginController : BaseController
    {
        private AccountService _accountService;
        private WeixinService _weixinService;
        private IQrCodeLoginCache _qrCodeLoginCache;
        public LoginController(WeixinService weixinService, IQrCodeLoginCache qrCodeLoginCache, AccountService accountService)
        {
            _weixinService = weixinService;
            _qrCodeLoginCache = qrCodeLoginCache;
            this._accountService = accountService;
        }
    }
}
