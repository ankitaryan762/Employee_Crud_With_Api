import React, {Component} from 'react';
import {Modal, Button, Row, Col, Form} from 'react-bootstrap';
import axios from 'axios'

import Snackbar from '@material-ui/core/SnackBar';
import IconButton from '@material-ui/core/IconButton'; 

export class Update extends Component{

    constructor(props)
    {
        super(props)
        this.state = {
            Id:'',
            Fname: '',
            Lname: '',
            Email:'',
            Password:'',
            City:'',
            Address:'', 
            snackbaropen: false,snackbarmsg:''
    
    };
         this.handleSubmit = this.handleSubmit.bind(this);
    }

    snackbarClose = () =>
    {
        this.setState({snackbaropen:false});
    };

    changeHandler = (event) => {
        this.setState({[event.target.name]: event.target.value})
    }

    handleSubmit = event =>{
        event.preventDefault()
        console.log(this.state)
        axios.put('https://localhost:44304/api/Employee/Api/UpdateEmployee', this.state)
        .then(response => {
            console.log(response)
            this.setState({snackbaropen:true, snackbarmsg:'result'});
        })
        .catch(error => {
            console.log(error)
            this.setState({snackbaropen:true, snackbarmsg:'failed'})
        })
    }

    render()
    {
        const {Id,Fname,Lname ,Email, Password,City,Address} = this.state 
        return(
            <div className="container">
                <Snackbar 
                anchorOrigin={{vertical:'bottom',horizontal:'bottom'}}
                open = {this.state.snackbaropen}
                autoHideDuration = {3000}
                onClose={this.snackbarClose}
                message={<span id="message-id">{this.state.snackbarmsg}</span>}
                action={[
                        <IconButton
                        key="close"
                        arial-label="close"
                        color="inherit"
                        onClick={this.snackbarClose}
                        >
                        x
                        </IconButton>
                       ]}
                />
            <Modal
                {...this.props}
                size="lg"
                aria-labelledby="contained-modal-title-vcenter"
                centered
            >
            <Modal.Header closeButton>
                <Modal.Title id="contained-modal-title-vcenter">
                    Update Employee
                </Modal.Title>
            </Modal.Header>
                <Modal.Body>
                        <Row>
                            <Col sm={6}>
                                <Form onSubmit={this.handleSubmit}>
                                <Form.Group controlId="Id">
                                        <Form.Label>EmployeeId</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="Id"
                                            value={Id}
                                            onChange={this.changeHandler}
                                            required
                                            disabled
                                            defaultValue = {this.props.empId}
                                            placeholder="Id"
                                        />
                                </Form.Group>
                                <Form.Group controlId="Fname">
                                    <Form.Label>Fname</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="Fname"
                                            value={Fname}
                                            onChange={this.changeHandler}   
                                            required
                                            defaultValue = {this.props.Fname}
                                            placeholder="Fname"
                                        />
                                </Form.Group>
                                <Form.Group controlId="Lname">
                                    <Form.Label>Lname</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="Lname"
                                            value={Lname}
                                            onChange={this.changeHandler}   
                                            required
                                            defaultValue = {this.props.Lname}
                                            placeholder="Lname"
                                        />
                                </Form.Group>
                                <Form.Group controlId="Email">
                                    <Form.Label>Email Id</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="Email"
                                            value={Email}
                                            onChange={this.changeHandler}
                                            required
                                            defaultValue = {this.props.Email}
                                            placeholder="Email"
                                        />
                                </Form.Group>
                                <Form.Group controlId="Password">
                                    <Form.Label>Password</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="Password"
                                            value={Password}
                                            onChange={this.changeHandler}
                                            required
                                            defaultValue = {this.props.Password}
                                            placeholder="Password"
                                        />
                                </Form.Group>
                                <Form.Group controlId="City">
                                    <Form.Label>City</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="City"
                                            value={City}
                                            onChange={this.changeHandler}
                                            required
                                            defaultValue = {this.props.City}
                                            placeholder="City"
                                        />
                                </Form.Group>
                                <Form.Group controlId="Address">
                                    <Form.Label>Address</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="Address"
                                            value={Address}
                                            onChange={this.changeHandler}
                                            required
                                            defaultValue = {this.props.Address}
                                            placeholder="Address"
                                        />
                                </Form.Group>
                                <Form.Group>
                                    <Button variant="primary" type="submit">
                                    Edit Employee
                                    </Button>   
                                </Form.Group>
                                </Form>
                            </Col>
                        </Row>
                </Modal.Body>
                <Modal.Footer>
                    <Button onClick={this.props.onHide}>Close</Button>
                </Modal.Footer>
                </Modal>
            </div>
        )
    }
}