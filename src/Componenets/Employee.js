import React, { Component } from 'react';
import axios from 'axios';

export default class Employee extends Component {
    constructor(props) {
        super(props)
        this.state = {
            employee: []
        }
    }
    componentDidMount()
    {
        axios.get("https://localhost:44304/api/Employee/GetAllEmployeee")
        .then(response=>{
            const employee = response.data;
            this.setState({
                employee:employee
            })
        })
    }
    render() {
        return (
            <>
                <div className="container_first">
                    <p id="record">No Record Found!!</p>
                </div>
                <div className="container_second">
                    <table className="table">
                        <tr>
                            <th>Firstname</th>
                            <th>Lastname</th>
                            <th>Email</th>
                            <th>Edit</th>
                            <th>Delete</th>
                        </tr>
                        <tbody>
                            {
                                this.state.employee.map(emp => 
                                    <tr key={emp.employee_id}>
                                        <td>{emp.firstName}</td>
                                        <td>{emp.lastName}</td>
                                        <td>{emp.emailId}</td>
                                        <td><button>edit</button></td>
                                        <td><button>delete</button></td>
                                    </tr>
                                )
                            }

                        </tbody>
                    </table>
                </div>
            </>
        )
    }
}