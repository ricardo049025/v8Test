import React, {useState, useEffect} from "react";
import {Table} from '../Components/Task3/Table.js';
import swal from 'sweetalert';

const Task3 = () =>{

    const SERVER_API = "https://localhost:44382/";
    const [data, setData] = useState([]);
    const [dataEmployee, setDataEmployee] = useState([]);

    const [employee, setEmployee] = useState("0");    

    const loadRecords = () => {
        fetch(`${SERVER_API}salary/GetCalculatedSalary`,{
            method:"get",
            headers:{
                'Content-Type': 'application/json'
            }
        }).then(result => result.json()).then(response => {
            setData(response);
        });
    }

    const loadEmployees = () => {
        fetch(`${SERVER_API}salary/GetEmployees`,{
            method:"get",
            headers:{
                'Content-Type': 'application/json'
            }
        }).then(result => result.json()).then(response => {
            setDataEmployee(response);            
        });
    }
    
    

    const getEmployeeFilter = (e,value) =>{
        
        if(employee == "0"){
            swal("Error", "Debe seleccionar un empleado para realizar la busqueda", "error");
            return;
        }

        fetch(`${SERVER_API}salary/getEmployeesFilter/?identification=${employee}&filterType=${value}`,{
            method:"GET",            
            headers:{
                'Content-Type': 'application/json'
            },                       
        }).then(response => response.json()).then(response => {                        
            setData(response);
        }).catch(
            error => alert("error aqui")
        );        

    };

    useEffect(() => {
        const loadDependencies = () => {
            loadRecords();
            loadEmployees();
        }

        loadDependencies();
        
    },[])

    return (

        <main className="app-content">
            <div className="app-title">
                <div>
                    <h1><i className="fa fa-dashboard" /> Task #3 y #4</h1>
                    <p>.Show a data table with calculated salaries, considering the last salary of the employee</p>
                    <p>.Add the following information filters expressed as buttons</p>
                </div>
            </div>

            <div className="row">
                <div className="col-md-12">
                    <div className="tile">
                        <div className="tile-body">
                            <div className="row">
                                <div className="col-sm-12 col-md-6 col-lg-4">
                                   
                                    <select className="w-100 m-1" value={employee}
                                    onChange={(event) => setEmployee(event.currentTarget.value)} >
                                    {dataEmployee.map((item,index) => (
                                        <option key={index} value={item.identification}>
                                            {item.fullName}
                                        </option>
                                    ))}
                                    </select>
                                </div>

                                <div className="row">
                                    <div className="col-sm-12">
                                        <div className="btn-group btn-group-toggle" data-toggle="buttons" >
                                            <label className="btn btn-primary active" onClick={(e) => getEmployeeFilter(e,1)}>
                                                <input id="option1" type="radio" name="options" autoComplete="off" value="1"/>Same Office & Grade
                                            </label>
                                            <label className="btn btn-primary" onClick={(e) => getEmployeeFilter(e,2)}>
                                                <input id="option2" type="radio" name="options" autoComplete="off" value="2"/>All Office & Same Grade
                                            </label>
                                            <label className="btn btn-primary" onClick={(e) => getEmployeeFilter(e,3)}>
                                                <input id="option3" type="radio" name="options" autoComplete="off" value="3"/>Same Position & Grade 
                                            </label>
                                            <label className="btn btn-primary" onClick={(e) => getEmployeeFilter(e,4)}>
                                                <input id="option4" type="radio" name="options" autoComplete="off" value="4"/> All Position & Same Grade 
                                            </label>
                                            </div>

                                        </div>
                                    </div>
                                </div>

                            <br/>
                            <Table data={data} />
                        </div>
                    </div>
                </div>
            </div>
            
        </main>

    )

}

export default Task3;