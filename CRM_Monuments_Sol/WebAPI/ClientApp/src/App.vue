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
</style>
