export type User = {
  id: number;
  displayName: string;
  emailAddress: string;
  token: string;
  imageUrl?: string;
}

export type LoginCredentials = {
  emailAddress: string;
  password: string;
}

export type RegisterCredentials = {
  emailAddress: string;
  displayName: string;
  password: string;
}
