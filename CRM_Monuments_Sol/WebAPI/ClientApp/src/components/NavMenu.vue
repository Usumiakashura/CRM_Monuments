<template>
        <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow">
            <div class="container menu">
                <!--<a class="navbar-brand">Vue JS Template for .NET 5</a>-->
                <a class="navbar-brand">
                    <router-link :to="{ name: 'Home' }">
                        <img src="../assets/logo1.png" class="logo" />
                    </router-link>
                </a>
                <button class="navbar-toggler"
                        type="button"
                        data-toggle="collapse"
                        data-target=".navbar-collapse"
                        aria-label="Toggle navigation"
                        @click="toggle">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="navbar-collapse collapse d-sm-inline-flex justify-content-between"
                     v-bind:class="{show: isExpanded}">
                    <ul class="navbar-nav flex-grow">
                        <li class="nav-item">
                            <router-link :to="{ name: 'Home' }" class="nav-link text-dark">Главная</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link :to="{ name: 'Home' }" class="nav-link text-dark">Настройки</router-link>
                        </li>
                        
                    </ul>
                </div>
            </div>
        </nav>
</template>


<style>
    a.navbar-brand {
        white-space: normal;
        text-align: center;
        word-break: break-all;
    }

    html {
        font-size: 14px;
    }

    @media (min-width: 768px) {
        html {
            font-size: 16px;
        }
    }

    .box-shadow {
        box-shadow: 0 .25rem .75rem rgba(0, 0, 0, .05);
    }

    .nav-link {
        padding: 0.8rem 1rem 0.1rem 1rem;
    }

    .logo {
        height: 30px;
    }

    .menu {
        max-width: 1200px;
    }

    .navbar {
        padding: 0px
    }
</style>
<script charset="utf-8">
    export default {
        name: "NavMenu",
        data() {
            return {
                isExpanded: false
            }
        },
        methods: {
            collapse() {
                this.isExpanded = false;
            },

            toggle() {
                this.isExpanded = !this.isExpanded;
            }
        }
    }
</script>