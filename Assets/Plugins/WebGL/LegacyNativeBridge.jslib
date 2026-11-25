// No-op WebGL implementations for legacy native integrations that are not
// available in this project. Real-money purchasing is intentionally excluded.
mergeInto(LibraryManager.library, {
  // Facebook iOS bridge: WebGL remains logged out and returns no access token.
  _facebookInit: function () {},
  facebookInit: function () {},
  _facebookIsLoggedIn: function () { return 0; },
  facebookIsLoggedIn: function () { return 0; },
  _facebookGetFacebookAccessToken: function () { return 0; },
  facebookGetFacebookAccessToken: function () { return 0; },
  _facebookExtendAccessToken: function () {},
  facebookExtendAccessToken: function () {},
  _facebookLoginWithRequestedPermissions: function () {},
  facebookLoginWithRequestedPermissions: function () {},
  _facebookLogout: function () {},
  facebookLogout: function () {},
  _facebookShowDialog: function () {},
  facebookShowDialog: function () {},
  _facebookRestRequest: function () {},
  facebookRestRequest: function () {},

  // Chartboost bridge: no ads or interstitials are available in WebGL.
  bridge_initAndStartSession: function () {},
  bridge_cacheInterstitial: function () {},
  bridge_cacheInterstitialLocation: function () {},
  bridge_showInterstitial: function () {},
  bridge_showInterstitialLocation: function () {},
  bridge_hasCachedInterstitial: function () { return 0; },
  bridge_hasCachedInterstitialLocation: function () { return 0; },
  bridge_cacheMoreApps: function () {},
  bridge_showMoreApps: function () {},
  bridge_getShouldRequestInterstitial: function () { return 0; },
  bridge_setShouldRequestInterstitial: function () {},
  bridge_getShouldDisplayInterstitial: function () { return 0; },
  bridge_setShouldDisplayInterstitial: function () {},
  bridge_getShouldDisplayLoadingViewForMoreApps: function () { return 0; },
  bridge_setShouldDisplayLoadingViewForMoreApps: function () {},
  bridge_getShouldDisplayMoreApps: function () { return 0; },
  bridge_setShouldDisplayMoreApps: function () {},

  // Flurry video-ad bridge: no rewarded video ads are offered in WebGL.
  fcbridge_initAndEnableVideoAds: function () {},
  fcbridge_videoAdIsAvailable: function () { return 0; },
  fcbridge_openVideoTakeover: function () {}
});
