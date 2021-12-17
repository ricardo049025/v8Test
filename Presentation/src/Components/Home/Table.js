import '../../plugins/css/main.css'
import {useState,useEffect} from "react";
import {ModalComponent} from "./Modal.Component.js";


const $ = require('jquery');
$.DataTable = require('datatables.net');

export const Table = (props) => {

    const[showModal, setShowModal] = useState(false);
    const [selectedRecord, setSelectedRecord] = useState(null);

    const onClickBtn = (record) => {
        setSelectedRecord(record);
        setShowModal(true);
    }

    useEffect(() => {

        setTimeout(()=>{
          $(".datatable").DataTable();
        },2500)
    }, [])

    return(

        <div className="table-responsive">
            <table className="datatable table table-hover table-bordered">
                <thead>
                    <tr>        
                        <th hidden={true}>Id</th>
                        <th>Options</th>
                        <th>Full Name</th>                        
                        <th>Year</th>
                        <th>Month</th>
                        <th>Grade</th>
                        <th>Identification</th>
                        <th>Base Salary</th>
                        <th>Productio Bonus</th>
                        <th>Compensation Bonus</th>
                        <th>Comission</th>
                        <th>Contribution</th>
                        
                    </tr>
                </thead>
                <tbody>
                        {props.data.map(item => (
                        <tr key={item.id}>
                            <td hidden={true}>{item.id}</td>
                            <td>
                                <button type="button" className="btn btn-success btn-sm" onClick={() => onClickBtn(item)}><i className="fa fa-plus" aria-hidden="true"></i> <i className    ="fa fa-pencil" aria-hidden="true"></i></button>
                            </td>
                            <td>{item.name} {item.surname}</td>                            
                            <td>{item.year}</td>
                            <td>{item.month}</td>
                            <td>{item.grade}</td>
                            <td>{item.identification}</td>
                            <td>{item.baseSalary}</td>
                            <td>{item.productionBonus}</td>
                            <td>{item.compensationBonus}</td>
                            <td>{item.comission}</td>
                            <td>{item.contribution}</td>                            
                        </tr>
                    ))}
                </tbody>
            </table>
            
            <ModalComponent show={showModal} onClose={() => setShowModal(false)} record={selectedRecord} />
        </div>
    );
}
