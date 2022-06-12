/**
    *  Если написать что-то не на ANSII (EN), то  автоматически будет выбрана кодировка UTF-8
    *  Это происходит автоматически. Больше ничего делать не нужно.
    */
import 'bootstrap/dist/css/bootstrap.css'
import { createApp } from 'vue'
import App from './App.vue'
import router from './router'


createApp(App).use(router).mount('#app')
