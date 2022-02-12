-- DOC 1

USE soft_uni;

-- 16
SELECT project_id id, name as 'Name', 
	description as 'Description', 
    start_date, 
    end_date 
FROM projects
ORDER BY start_date, name
LIMIT 10;

-- 21
USE geography;

SELECT country_name, 
	country_code, 
    CASE 
		WHEN currency_code = 'EUR' THEN 'Euro'
        ELSE 'Not Euro' 
        END as currency
FROM countries
ORDER BY country_name;

-- 8
SELECT employee_id as id, 
	first_name as 'First Name', 
    last_name as 'Last Name',
    middle_name as 'Middle Name',
    job_title as 'Job Tilte',
    department_id as 'Dept ID',
    manager_id as 'Mngr ID',
    hire_date as 'Hire Date',
    salary,
    address_id
FROM employees
WHERE job_title = 'Sales Representative';

-- 12
SELECT first_name, last_name, salary 
FROM employees
WHERE salary > 50000
ORDER BY salary DESC;

-- 13
SELECT first_name, last_name
FROM employees
ORDER BY salary DESC
LIMIT 5;

-- 14
SELECT department_id
FROM departments
WHERE name = 'Marketing';

SELECT first_name, last_name
FROM employees
WHERE department_id <> 4;

SELECT first_name, last_name
FROM employees
WHERE department_id <> (SELECT department_id
	FROM departments
	WHERE name = 'Marketing');

-- 19
USE geography;

SELECT peak_name FROM peaks
ORDER BY peak_name ASC;

-- 17
USE soft_uni;

SELECT first_name, last_name, hire_date
FROM employees
ORDER BY hire_date DESC
LIMIT 7;









