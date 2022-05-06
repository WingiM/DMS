import "./ModalWindow.css";
import React from "react";
import hmacSHA512 from 'crypto-js/hmac-sha512';

function template() {
  return (
      this.state.show ? 
      <div id="myModal" className="modal-window">
          <div className="modal-content">
              <div className="modal-header">
                  <span className="close">&times;</span>
                  <h2>Modal Header</h2>
              </div>
              <div className="modal-body">
                  <p>Some text in the Modal Body</p>
                  <p>Some other text...</p>
              </div>
              <div className="modal-footer">
                  <h3>Modal Footer</h3>
              </div>
          </div>

      </div> : ''
  );
};

export default template;
