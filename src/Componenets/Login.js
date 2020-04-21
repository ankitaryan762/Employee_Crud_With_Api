import React,{Component} from 'react';
import {Container,Button,Col,Row,Form} from 'react-bootstrap';
import { Redirect } from 'react-router-dom';
import './loginCss.css';
import {axios} from 'axios'

 export class Login extends Component {
constructor(props){
    super(props)
    this.state = {
        Email:"",
        Password: "",
        loginAuthentication : false
    }
}

handleEmailChange=(event)=>{
    const Email=event.target.value;
    this.setState({
        Email:Email
    })
    console.log("Email",this.state.Email)
}


handlePasswordChange=(event)=>{
    const Password=event.target.value;
    this.setState({
        Password:Password
    })
    console.log("Password",this.state.Password)
}

handleSubmitButton=(event)=>{
    event.preventDefault();
    var data ={
        Email: this.state.Email,
        Password: this.state.Password
    }
    axios.post('https://localhost:44304/api/Employee/Api/Login', data)
    .then(res=>{
        console.log(res.data);
        if(res.data === data.Email && res.data === data.Password)
        {
            this.setState({
                loginAuthentication:true
            })
        }
    })
 //   console.log("status", this.state.email, this.state.password);
}

    render() {
        if(this.state.loginAuthentication === true){
            return <Redirect to = '/employee'/>
        }
        return (
            <Container>
            <Row>
            <Col></Col>
            <Col xs={6}>
            <Form action="" name="myForm">
            <h3 className = "m-4 d-flex justify-content-center">
                Login Page
            </h3>
            <Form.Group controlId="formBasicEmail">
                <Form.Label>Email address</Form.Label>
                <Form.Control type="email" placeholder="Enter email" onChange={this.handleEmailChange}/>
                <Form.Text className="text-muted">
                 We'll never share your email with anyone else.
                </Form.Text>
            </Form.Group>
            <Form.Group controlId="formBasicPassword">
                <Form.Label>Password</Form.Label>
                <Form.Control type="password" placeholder="Password" onChange={this.handlePasswordChange}/>
            </Form.Group>
            <Form.Group controlId="formBasicCheckbox">
                <Form.Check type="checkbox" label="Remember Me" />
            </Form.Group>
            <Button variant="primary" type="submit" onClick={this.handleSubmitButton} >
                Submit
            </Button>
            </Form>
            </Col>
            <Col></Col>
            </Row>
            </Container>
        );
    }
}
