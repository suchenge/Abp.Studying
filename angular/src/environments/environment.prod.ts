import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Studying',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44354',
    redirectUri: baseUrl,
    clientId: 'Studying_App',
    responseType: 'code',
    scope: 'offline_access Studying',
  },
  apis: {
    default: {
      url: 'https://localhost:44333',
      rootNamespace: 'Abp.Studying',
    },
  },
} as Environment;
