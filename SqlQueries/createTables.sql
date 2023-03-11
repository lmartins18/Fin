CREATE TABLE icons (
  id SERIAL PRIMARY KEY,
  name VARCHAR(20)
);
CREATE TABLE categories (
  id SERIAL PRIMARY KEY,
  name VARCHAR(20)
);
CREATE TABLE accounts (
  id SERIAL PRIMARY KEY,
  name VARCHAR(20),
  balance DECIMAL,
  category_id INTEGER REFERENCES categories(id),
  icon_id INTEGER REFERENCES icons(id)
);
CREATE TABLE transactions (
  id SERIAL PRIMARY KEY,
  name VARCHAR(20),
  amount DECIMAL,
  account_id INTEGER REFERENCES accounts(id),
  is_credit BOOLEAN,
  category_id INTEGER REFERENCES categories(id),
  date TIMESTAMP
);
CREATE TABLE goals (
  id SERIAL PRIMARY KEY,
  name VARCHAR(20),
  amount_achieved DECIMAL,
  amount_to_achieve DECIMAL
);