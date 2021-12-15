import {useState} from "react";
import {Table} from "react-bootstrap";
import {ModalComponent} from "../modal/modal.component";

export const TableComponent = (props) => {

    const[showModal, setShowModal] = useState(false);
    const [selectedRecord, setSelectedRecord] = useState(null);

    const onClickBtn = (record) => {
        setSelectedRecord(record);
        setShowModal(true);
    }
    return(
        <>
        <Table striped bordered hover>
  <thead>
    <tr>
      <th hidden={true}>Id</th>
      <th>Name</th>
      <th>SurName</th>
      <th>Year</th>
      <th>Month</th>
      <th>Grade</th>
      <th>Identification</th>
      <th>Base Salary</th>
      <th>Productio Bonus</th>
      <th>Compensation Bonus</th>
      <th>Comission</th>
      <th>Contribution</th>
      <th></th>
    </tr>
  </thead>
  <tbody>
    {props.data.map(item => (
        <tr key={item.id}>
            <td hidden={true}>{item.id}</td>
            <td>{item.name}</td>
            <td>{item.surname}</td>
            <td>{item.year}</td>
            <td>{item.month}</td>
            <td>{item.grade}</td>
            <td>{item.identification}</td>
            <td>{item.baseSalary}</td>
            <td>{item.productionBonus}</td>
            <td>{item.compensationBonus}</td>
            <td>{item.comission}</td>
            <td>{item.contribution}</td>
            <td>
                <button type="button" className="btn btn-success" onClick={() => onClickBtn(item)}>Add / Edit</button>
            </td>
        </tr>
    ))}
  </tbody>
</Table>
<ModalComponent 
 show={showModal}
 onClose={() => setShowModal(false)}
 record={selectedRecord}
/>
</>
    );
}