select 
    d.database_id,
	d.name as 'database',
    ldf.physical_name as 'log_file',
	ldf.size as 'log_size'
from sys.databases d
inner join sys.master_files ldf on 
    d.database_id = ldf.database_id and ldf.[type] = 1
order by ldf.size desc
