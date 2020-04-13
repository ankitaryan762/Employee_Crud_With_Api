import React from 'react';
const style = {
  width: '500px', 
  margin: 'auto'
}
const login = (props) => {
  return (
    <>
      <h1>Login</h1>
      <form className=" p-5 bg-light text-primary" style = {style} >
        <div className="form-group">
          <label for="email">Email :</label>
          <input type="text" id="email" class="form-control " />

        </div>
        <div class="form-group">
          <label for="password">Password :</label>
          <input type="password" id="password" class="form-control " />
        </div>
        <div class="form-group text-danger" id="error">

        </div>
        <div class="form-group text-secondary">
          Don't have an account ? <a href="">register</a>
        </div>
        <button type="submit" class="btn btn-success" id="submitBtn" disabled>Submit</button>
      </form>
    </>
  )

};
export default login;