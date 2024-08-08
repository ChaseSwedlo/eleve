import { listen, select } from './utils.js';
'use strict';

const hamburger = document.querySelector('.hamburger');
const hamburgerMenu = document.querySelector('.hamburger-menu');
const navLinks = document.querySelectorAll('.nav-link');

hamburger.addEventListener('click', () => {
  hamburger.classList.toggle('open');
  hamburgerMenu.classList.toggle('open');
});