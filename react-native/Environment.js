const ENV = {
  dev: {
    apiUrl: 'http://localhost:44333',
    oAuthConfig: {
      issuer: 'http://localhost:44354',
      clientId: 'Studying_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access Studying',
    },
    localization: {
      defaultResourceName: 'Studying',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44333',
    oAuthConfig: {
      issuer: 'http://localhost:44354',
      clientId: 'Studying_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access Studying',
    },
    localization: {
      defaultResourceName: 'Studying',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
