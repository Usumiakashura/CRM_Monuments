<template>
    <header>
        <nav-menu></nav-menu>
        <user-menu></user-menu>
    </header>
    
    <router-view />
</template>

<script>
    import NavMenu from './components/NavMenu.vue'
    import UserMenu from './components/UserMenu.vue'

    export default {
        name: 'App',
        components: {
            NavMenu,
            UserMenu
        }
    }
</script>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
    }
    
    body {
        color: #303030;
        background-image: url('assets/bcgr.jpg');
        -moz-background-size: cover; /* Firefox 3.6+ */
        -webkit-background-size: cover; /* Safari 3.1+ и Chrome 4.0+ */
        -o-background-size: cover; /* Opera 9.6+ */
        background-size: cover; /* Современные браузеры */
        background-repeat: no-repeat;
        background-attachment: fixed;
    }

    label {
        margin-bottom: 0px;
        
    }

    .add-btn {
        height: 30px;
    }
        .add-btn :hover {
            cursor: pointer;
        }

    .container {
        max-width: 1350px;
    }

    .content-box-max {
        width: 100%;
        margin: auto;
        padding: 10px 0px;
        background-color: #ffffff;
        opacity: 0.85;
    }

    .flex {
        display: flex;
    }

    .full {
        width: 100%;
    }

    .results tr[visible='false'],
    .no-result {
        display: none;
    }

    .results tr[visible='true'] {
        display: table-row;
    }

    .table td {
        padding: 0px 5px;
        /*font-size: 12px;*/
        vertical-align: central;
        /*border-top: 1px solid #dee2e6;*/
    }

    .table th {
        padding: 0px 5px;
    }

    .table {
        /*width: max-content;*/
        background-color: #ffffff;
        opacity: 1;
        text-align: left;
    }
    .table-stroke :hover {
        cursor: pointer;
    }


</style>
