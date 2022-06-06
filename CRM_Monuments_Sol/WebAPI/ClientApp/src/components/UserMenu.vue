<template>



        <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3 padd0">
            <div class="container menu">
                
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
                            <router-link :to="{ name: 'Contracts' }" class="link text-dark">Договора</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link :to="{ name: 'Portraits' }" class="link text-dark">Портреты</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link :to="{ name: 'Medallions' }" class="link text-dark">Медальоны</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link :to="{ name: 'Texts' }" class="link text-dark">Текста</router-link>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
</template>


<style>
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

    .link {
        display: block;
        padding-right: 1rem;
        padding-top: 0.2rem;
    }
        .link:hover {
            text-decoration: none;
        }

    .padd0 {
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