import {Modal, Button} from "react-bootstrap";
import { useState, useEffect } from "react";

export const ModalComponent = (props) => {
    const SERVER_API = "https://localhost:44382/";    
    const [details, setDetails] = useState({name:"", surname:"", from: new Date().toISOString().substr(0,10), to: new Date().toISOString().substr(0,10),
    employeeCode:"", birthDay: new Date().toISOString().substr(0,10), beginDate: new Date().toISOString().substr(0,10),
    identification:"", grade:0, identification:"", baseSalary:0, productionBonus:0, compensationBonus:0,
    comission:0, contribution:0, positionId:0, divisionId:0, officeId:0, updateRecord: true});
    const [offices, setOffices] = useState([]);
    const [position, setPosition] = useState([]);
    const [division, setDivision] = useState([]);
    

    const saveRecord = () => {
        const data = {

            name: details.name,
            surname: details.surname,
            fromDate: details.from,
            toDate: details.to,
            code: details.employeeCode,
            grade: details.grade,
            beginDate: details.beginDate,
            birthDay: details.birthDay,
            identification: details.identification,
            baseSalary: details.baseSalary,
            productionBonus : details.productionBonus,
            compensationBonus: details.compensationBonus,
            comission: details.comission,
            contribution: details.contribution,
            officeId: details.officeId,
            divisionId: details.divisionId,
            positionId: details.positionId,
            updateRecord: details.updateRecord
        }
        fetch(`${SERVER_API}salary/AddSalary`,{
            method:"post",
            headers:{
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(data)
        }).then(response => response.json())
        .then(response => {
            alert(response.message);
        }).catch(error => alert("error aqui"));
    }

    const loadOffices = () => {
        fetch(`${SERVER_API}office`,{
            method:"get",
            headers:{
                'Content-Type': 'application/json'
            }
        })
        .then(res => res.json())
        .then(res => {
            setOffices(res);
        })
    }
    const loadDivision = () => {
        fetch(`${SERVER_API}division`,{
            method:"get",
            headers:{
                'Content-Type': 'application/json'
            }
        })
        .then(res => res.json())
        .then(res => {
            setDivision(res);
        })
    }
    const loadPosition = () => {
        fetch(`${SERVER_API}position`,{
            method:"get",
            headers:{
                'Content-Type': 'application/json'
            }
        })
        .then(res => res.json())
        .then(res => {
            setPosition(res);
        })
    }
    useEffect(() => {
        const loadDependencies = () => {
            loadOffices();
            loadDivision();
            loadPosition();
        }
        loadDependencies();
    }, [])

    useEffect(() => {
        if(!props.record){
            setDetails({name:"", surname:"", from: new Date().toISOString().substr(0,10), to: new Date().toISOString().substr(0,10),
                        employeeCode:"", birthDay: new Date().toISOString().substr(0,10), beginDate: new Date().toISOString().substr(0,10),
                        identification:"", grade:0, identification:"", baseSalary:0, productionBonus:0, compensationBonus:0,
                        comission:0, contribution:0, positionId:0, divisionId:0, officeId:0, updateRecord: true} );
        }else{
            setDetails(props.record);
        }

    }, [props.record])

    return(
        <>
          <Modal show={props.show} onHide={props.onClose} size="lg">
        <Modal.Header closeButton>
          <Modal.Title>Employee Details</Modal.Title>
        </Modal.Header>
        <Modal.Body>
            
            <div className="row">
                <div className="col-md-6">
                    <label className="form-label">Name</label>
                    <input className="form-control" type="text" onChange={(e) => setDetails({...details, name:e.currentTarget.value})} value={details.name} className="w-100 m-1" placeholder="Name"/>
                </div>
                <div className="col-md-6">
                    <label className="form-label">SurName</label>
                    <input type="text" onChange={(e) => setDetails({...details, surname:e.currentTarget.value})} value={details.surname} className="w-100 m-1" placeholder="Surname"/>
                </div>
            </div>
            
            <div className="row">
                <div className="col-md-6">
                    <label className="form-label">from Date</label>
                    <input className="w-100 m-1" onChange={(e) => setDetails({...details, from:e.currentTarget.value})} value={details.from} type="date" placeholder="Salary Date Begin"/>
                </div>
                <div className="col-md-6">
                    <label className="form-label">to Date</label>
                    <input type="date" onChange={(e) => setDetails({...details, to:e.currentTarget.value})} value={details.to} className="w-100 m-1" placeholder="Salary Date End"/>
                </div>
            </div>
            
            <div className="row">
                <div className="col-md-6">
                    <label className="form-label">Employee Code</label>
                    <input className="w-100 m-1" onChange={(e) => setDetails({...details, employeeCode:e.currentTarget.value})} value={details.employeeCode} type="text" placeholder="Employee Code"/>
                </div>
                <div className="col-md-6">
                    <label className="form-label">Identification</label>
                    <input type="text" onChange={(e) => setDetails({...details, identification: e.currentTarget.value})} value={details.identification} className="w-100 m-1" placeholder="Identification"/>
                </div>
            </div>

            <div className="row">
                <div className="col-md-6">
                    <label className="form-label">Begin Date</label>
                    <input className="w-100 m-1" onChange={(e) => setDetails({...details, beginDate: e.currentTarget.value})} value={details.beginDate} type="date" placeholder="Begin Date"/>
                </div>
                <div className="col-md-6">
                    <label className="form-label">Birthday</label>
                    <input type="date"  onChange={(e) => setDetails({...details, birthDay: e.currentTarget.value})} className="w-100 m-1" placeholder="Birthday"/>
                </div>
            </div>

            <div className="row">
                <div className="col-md-6">
                    <label className="form-label">Base Salary</label>
                    <input className="w-100 m-1" onChange={(e) => setDetails({...details, baseSalary: e.currentTarget.value})} value={details.baseSalary} type="number" placeholder="Base Salary"/>
                </div>
                <div className="col-md-6">
                    <label className="form-label">Production Bonus</label>
                    <input type="number" onChange={(e) => setDetails({...details, productionBonus: e.currentTarget.value})} value={details.productionBonus} className="w-100 m-1" placeholder="Production Bonus"/>
                </div>
            </div>

            <div className="row">
                <div className="col-md-6">
                    <label className="form-label">Compensation Bonus</label>
                    <input className="w-100 m-1" onChange={(e) => setDetails({...details, compensationBonus: e.currentTarget.value})} value={details.compensationBonus} type="number" placeholder="Compensation Bonus"/>
                </div>
                <div className="col-md-6">
                    <label className="form-label">Commission</label>
                    <input className="w-100 m-1" onChange={(e) => setDetails({...details, comission: e.currentTarget.value})} value={details.comission} type="number" placeholder="Commision"/>                    
                </div>
            </div>

            <div className="row">
                <div className="col-md-6">
                    <label className="form-label">Contribution</label>
                    <input type="number" onChange={(e) => setDetails({...details, contribution: e.currentTarget.value})} value={details.contribution} className="w-100 m-1" placeholder="Contribution"/>
                </div>
                <div className="col-md-6">
                    <label className="form-label">Position</label>
                    <select
                    className="w-100 m-1"
                    name="positionId"
                    value={details.position}
                    onChange={(event) => setDetails({...details, position: event.currentTarget.value})}
                    >
                        {position.map((item) => (
                            <option key={item.id} value={item.id}>
                            {item.name}
                            </option>
                        ))}
                    </select>
                </div>
            </div>

            <div className="row">
                <div className="col-md-6">
                    <label className="form-label">Office</label>
                    <select
                        className="w-100 m-1"
                        name="officeId"
                        value={details.office}
                        onChange={(event) => setDetails({...details, office: event.currentTarget.value})}
                        >
                            {offices.map((item) => (
                                <option key={item.id} value={item.id}>
                                {item.name}
                                </option>
                            ))}
                    </select>
                </div>
                <div className="col-md-6">
                    <label className="form-label">Divition</label>
                    <select
                    className="w-100 m-1"
                    name="divisionId"
                    value={details.divisionId}
                    onChange={(event) => setDetails({...details, divisionId: event.currentTarget.value})}
                    >
                        {division.map((item) => (
                            <option key={item.id} value={item.id}>
                            {item.name}
                            </option>
                        ))}
                    </select>
                </div>
            </div>

            <div className="row">
                <div className="col-md-6">
                    <label className="form-label">Update Salaries</label>
                    <input onChange={(e) => setDetails({...details, updateRecord: e.currentTarget.checked})} value={details.updateRecord} type="checkbox"/>
                </div>
            </div>            
        </Modal.Body>
        <Modal.Footer>
          <Button variant="secondary" onClick={props.onClose}>
            Close
          </Button>
          <Button variant="primary" onClick={() => saveRecord()}>
            Save Changes
          </Button>
        </Modal.Footer>
      </Modal>
        </>
    );
}