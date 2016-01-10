MKDIR Respaldos_DB
MKDIR RespaldoDB.%date:/=-%

sqlite3 dbinsumos.db .dump > RespaldoDBInsumos.%date:/=-%.sql

MOVE RespaldoDBInsumos.%date:/=-%.sql RespaldoDB.%date:/=-%

MOVE RespaldoDB.%date:/=-% Respaldos_DB
