CREATE TABLE megobrebi (
    id INTEGER PRIMARY KEY,
    saxeli TEXT,
    asaki INTEGER,
    wona REAL);

INSERT INTO megobrebi VALUES (1, "Nika", 32, 165.5);
INSERT INTO megobrebi VALUES (2, "Luka", 30, 152.4);
INSERT INTO megobrebi VALUES (3, "Ani", NULL, NULL);

SELECT * FROM megobrebi;