import React, { Component } from 'react';

export default class Login extends Component {
  constructor(props) {
    super(props)
    this.state = {
      email: "",
      password: ""
    }
  }
  handleEmailChange = (event) => {
    const email = event.target.value;
    this.setState({
      email: email
    })
  }
  handlePasswordChange = (event) => {
    const password = event.target.value;
    this.setState({
      password: password
    })
  }
  handleSubmitButton = () => {
    var data = {
      Email: this.state.email,
      Password: this.state.password

    }
    console.log("data", data);
    console.log("status", this.state.email, this.state.password);
  }
  render() {
    return (
      <div className="main-div">
        <div className="test">
          <div className="login-div">Login here</div>
          <div className="main-Test-div">

            <div className="email-div">
              <input type="email" className="input-email-div" placeholder="Email" onChange={this.handleEmailChange} />
            </div>
            <div className="email-div">
              <input type="password" className="input-email-div" placeholder="Password" onChange={this.handlePasswordChange} />
            </div>

          </div>
          <div className="app-button">
            <button className="submit" onClick={this.handleSubmitButton}>Submit</button>
          </div>
          <div className="links">
            <a href="/Sign-up">Sign up</a>
            <p className="paragrapgh"> | </p>
            <a href="/Sign-up">Forgot Password</a>
          </div>
        </div>
      </div>
    )
  }
}