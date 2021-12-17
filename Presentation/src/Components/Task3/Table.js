import {useState,useEffect} from "react";


const $ = require('jquery');
$.DataTable = require('datatables.net');

export const Table = (props) => {

    
    const [selectedRecord, setSelectedRecord] = useState(null);
   
    // useEffect(() => {

    //     setTimeout(()=>{
    //       $(".datatable").DataTable({
    //         "bPaginate": true,
    //         "bLengthChange": false,
    //         "bFilter": true,
    //         "bInfo": true,
    //         "bAutoWidth": false,            
    //         "pageLength": 10
    //       });
    //     },2500)
    // }, [])

    return(

        <div className="table-responsive">
            <table className=" datatable table table-hover table-bordered">
                <thead>
                    <tr>    
                        <th>Full Name</th>
                        <th>Division</th>
                        <th>Position</th>
                        <th>Office</th>
                        <th>Grade</th>
                        <th>BeginDate</th>
                        <th>Birthday</th>
                        <th>IdentificationNumber</th>
                        <th>TotalSalary</th>
                    </tr>
                </thead>
                <tbody>
                        {props.data.map((item,index) => (
                        <tr key={index}>                            
                            <td>{item.fullName}</td>                            
                            <td>{item.divition}</td>
                            <td>{item.position}</td>
                            <td>{item.office}</td>
                            <td>{item.grade}</td>
                            <td>{item.beginDate}</td>
                            <td>{item.birthday}</td>
                            <td>{item.identificationNumber}</td>
                            <td>{item.totalSalary}</td>
                        </tr>
                    ))}
                </tbody>
            </table>            
        </div>

    );
}