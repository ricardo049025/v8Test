import '../plugins/css/main.css'
import React, {useState, useEffect} from "react";
import {Table} from '../Components/Task5/Table.js';
import {CardPane} from  '../Components/Task5/CardPane.js'

const Task5 = () =>{

    const SERVER_API = "https://localhost:44382/";
    // const [data, setData] = useState({bonus: 0, salaries:{id: 0, fullName:"", employeeCode:"", year: 0, month: 0, baseSalary: 0}});
    const [data, setData] = useState([]);
    const [bonus, setBonus] = useState(0);
    const [code, setCode] = useState("");

    const getEmployeeSalary = () => {

        fetch(`${SERVER_API}salary/GetLasthreeSalariesBonus/?employeeCode=${code}`,{
            method:"GET",            
            headers:{
                'Content-Type': 'application/json'
            },                       
        }).then(response => response.json()).then(response => {            
           setData(response.salaries)
           setBonus(response.bonus);
        }).catch(
            error => alert("error aqui")
        );
    }

    return(
        <main className="app-content">
            <div className="app-title">
                <div>
                    <h1><i className="fa fa-dashboard" /> Task #5</h1>
                    <p>Show the last 3 consecutive salaries based on the entry of an Employee Code</p>
                </div>
            </div>

            <div className="row">
                <div className="col-lg-8 col-md-8 col-sm-12">
                    <div className="tile">
                        <div className="tile-body">                        
                        <div className="row">
                            <ul className="offset-sm-2 offset-md-2 offset-lg-4">
                                <li className="app-search">
                                    <input className="app-search__input" type="search" placeholder="Search Employee Code" onChange={(e) => setCode(e.currentTarget.value)} value={code} />
                                    <button className="btn btn-sm btn-success" onClick={() => getEmployeeSalary()}><i className="fa fa-search" /></button>
                                </li>
                            </ul>
                        </div>
                            <Table data={data}/>
                        </div>
                    </div>
                </div>

                <div className="col-lg-4 col-md-4 col-sm-12">
                    <CardPane bonus={bonus}/>
                </div>

            </div>
            
        </main>
    )
}

export default Task5;