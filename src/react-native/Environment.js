const ENV = {
  dev: {
    apiUrl: 'http://localhost:44340',
    oAuthConfig: {
      issuer: 'http://localhost:44340',
      clientId: 'Nc_App',
      clientSecret: '1q2w3e*',
      scope: 'Nc',
    },
    localization: {
      defaultResourceName: 'Nc',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44340',
    oAuthConfig: {
      issuer: 'http://localhost:44340',
      clientId: 'Nc_App',
      clientSecret: '1q2w3e*',
      scope: 'Nc',
    },
    localization: {
      defaultResourceName: 'Nc',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
