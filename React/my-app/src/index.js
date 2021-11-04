import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import LifecycleDemo from './LifecycleDemo';
import reportWebVitals from './reportWebVitals';
// import App from './App';
// import MyComponent from './MyComponent';
// import MyClassComponent from './MyClassComponent';

ReactDOM.render(
  <React.StrictMode>
    {/* <App /> */}
    <LifecycleDemo />
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
