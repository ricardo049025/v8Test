
import {useState,useEffect} from "react";

export const Table = (props) => {

    return(
        <>
    <div className="row">
    <div className="table-responsive">
    <table className=" datatable table table-hover table-bordered">
        <thead>
            <tr>    
                <th>Full Name</th>
                <th>Employe Code</th>
                <th>Year</th>
                <th>Month</th>
                <th>Base Salary</th>                
            </tr>
        </thead>
        <tbody>
                {props.data.map((item,index) => (
                <tr key={index}>                            
                    <td>{item.fullName}</td>                            
                    <td>{item.employeeCode}</td>
                    <td>{item.year}</td>
                    <td>{item.month}</td>
                    <td>{item.baseSalary}</td>
                </tr>
            ))}
        </tbody>
    </table>            
</div>
      
    </div>
    </>
    )
};