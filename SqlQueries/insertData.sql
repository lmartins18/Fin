INSERT INTO icons (name)
VALUES ('wallet'), ('chart'), ('bitcoin');
INSERT INTO categories (name)
VALUES ('food'),('takeaway'), ('utilities'), ('transport'), ('health'), ('crypto'), ('real estate'), ('current');
INSERT INTO accounts (name, balance, category_id, icon_id)
VALUES ('current', 1000, 8, 1);
INSERT INTO transactions (name, amount, account_id, is_credit, category_id, date)
VALUES ('takeaway', 20, 1, false, 2, '2023-03-11');
INSERT INTO goals (name, amount_achieved, amount_to_achieve)
VALUES ('house', 0, 15000);



