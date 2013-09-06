ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [fleet_log], FILENAME = 'D:\Projects\Backoffice\WinClients\Sigma\Fleet\Database\fleet_log.ldf', SIZE = 35712 KB, MAXSIZE = 2097152 MB, FILEGROWTH = 10 %);



