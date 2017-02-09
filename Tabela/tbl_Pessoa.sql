CREATE TABLE tbl_Pessoa (
  pess_Id INTEGER  NOT NULL IDENTITY(1,1),
  pess_Nome VARCHAR(50) NOT NULL,
  pess_Email VARCHAR(30) NOT NULL,
  pess_Tag VARCHAR(7) NOT NULL,
  PRIMARY KEY(pess_Id)
);

