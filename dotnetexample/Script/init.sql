\c "dotnetExampleDb"

CREATE TABLE "User" (
    "Id" INTEGER PRIMARY KEY GENERATED BY DEFAULT AS IDENTITY,
    "Username" VARCHAR(50) NOT NULL,
    "Password" VARCHAR(50) NOT NULL,
);

INSERT INTO "User" ("Username", "Password") VALUES ('admin', 'admin');