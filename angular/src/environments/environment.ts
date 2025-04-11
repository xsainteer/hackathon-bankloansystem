import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'BankLoanSystem',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44312/',
    redirectUri: baseUrl,
    clientId: 'BankLoanSystem_App',
    responseType: 'code',
    scope: 'offline_access BankLoanSystem',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44312',
      rootNamespace: 'BankLoanSystem',
    },
  },
} as Environment;
