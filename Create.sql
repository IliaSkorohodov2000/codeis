Create table dbo.projectorg_ownership
(N_ownership int not NULL,
ownership_name char(30),
PRIMARY KEY (N_ownership)
)

Create table dbo.projectorg_statuses
(N_status int not NULL,
status_name char(30),
N_ownership int
PRIMARY KEY (N_status)
FOREIGN KEY (N_ownership) REFERENCES dbo.projectorg_ownership (N_ownership)
)

Create table dbo.projectorg_roles
(N_role int not NULL,
role_name char(30),
PRIMARY KEY (N_role)
)


Create table dbo.projectorg_employers
(N_employer int not NULL,
first_name char(30),
second_name char(30),
third_name char(30),
adress char(100),
telephone char(20),
passport_number char(15),
individual_number char(15),
birth_date datetime,
creation_date datetime,
last_change datetime,
var_status int,
department_number int
PRIMARY KEY (N_employer)
FOREIGN KEY (var_status) REFERENCES dbo.projectorg_statuses (N_status)
)

Create table dbo.projectorg_users
(N_user int not NULL,
user_login char(30),
user_password char(30),
user_role int,
employer_id int
PRIMARY KEY (N_user)
FOREIGN KEY (employer_id) REFERENCES dbo.projectorg_employers (N_employer), 
FOREIGN KEY (user_role) REFERENCES dbo.projectorg_roles (N_role)
)

Create table dbo.projectorg_departments
(N_department int not NULL,
department_name char(30),
telephone char(30),
department_leader int,
department_status int
PRIMARY KEY (N_department)
FOREIGN KEY (department_leader) REFERENCES dbo.projectorg_employers (N_employer),
FOREIGN KEY (department_status) REFERENCES dbo.projectorg_statuses (N_status)
)

Create table dbo.projectorg_equipment
(N_equipment int not NULL,
equipment_name char(30),
creation_date datetime,
brand_name char(30),
equipment_quantity int,
department_number int
PRIMARY KEY (N_equipment)
FOREIGN KEY (department_number) REFERENCES dbo.projectorg_departments (N_department)
)

Create table dbo.projectorg_customers
(N_customer int not NULL,
first_name char(30),
second_name char(30),
third_name char(30),
adress char(100),
passport_number char(15),
telephone char(20),
birth_date datetime,
creation_date datetime,
last_change datetime,
var_status int,
PRIMARY KEY (N_customer),
FOREIGN KEY (var_status) REFERENCES dbo.projectorg_statuses (N_status)
)

Create table dbo.projectorg_contracts
(N_contract int not NULL,
customer_id int,
signing_date datetime,
creation_date datetime,
last_change datetime,
var_status int,
PRIMARY KEY (N_contract),
FOREIGN KEY (var_status) REFERENCES dbo.projectorg_statuses (N_status)
)

Create table dbo.projectorg_projects
(N_project int not NULL,
project_name char(30),
contract_number int,
creation_date datetime,
ending_date datetime,
last_change datetime,
cost int,
var_status int,
PRIMARY KEY (N_project),
FOREIGN KEY (var_status) REFERENCES dbo.projectorg_statuses (N_status),
FOREIGN KEY (contract_number) REFERENCES dbo.projectorg_contracts (N_contract)
)

Create table dbo.projectorg_workonproject
(N_work int not NULL,
employer_id int,
project_id int,
var_status int,
PRIMARY KEY (N_work),
FOREIGN KEY (employer_id) REFERENCES dbo.projectorg_employers (N_employer),
FOREIGN KEY (project_id) REFERENCES dbo.projectorg_projects (N_project),
FOREIGN KEY (var_status) REFERENCES dbo.projectorg_statuses (N_status)
)

