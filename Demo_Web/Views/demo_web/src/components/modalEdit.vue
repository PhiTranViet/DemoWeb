<template>
    <div class="modal" tabindex="-1" role="dialog" id="editEmp">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Thêm mới nhân viên</h5>

                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>

                <div class="modal-body">
                    <div>
                        <div class="form-group">
                            <input type="text" v-model="employee.employeeCode" class="form-control" />
                        </div>

                        <div class="form-group">
                            <input type="text" v-model="employee.employeeName" class="form-control" placeholder="Tên nhân viên" />
                        </div>

                        <div class="form-group">
                            <input type="text" v-model.number="employee.age" class="form-control" placeholder="Tuổi" />
                        </div>

                        <div class="form-group">
                            <input type="text" v-model="employee.gender" class="form-control" placeholder="Giới tính" />
                        </div>

                        <div class="form-group">
                            <input type="text" v-model="employee.phone" class="form-control" placeholder="Số điện thoại" />
                        </div>

                        <div class="form-group">
                            <input type="text" v-model="employee.address" class="form-control" placeholder="Quê quán" />
                        </div>
                    </div>
                </div>

                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" data-dismiss="modal" v-on:click="getModalData()">Lưu</button>

                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: "modal",

        props: {
            employee: Object,
        },

        //props: ['employee'],

        data() {
            return {
                listEmployees: [],
            };
        },

        methods: {
            getModalData() {
                this.$emit("getEmpEdited", this.employee);
            },
        },
    };
</script>

<style scoped>
    .modal-dialog {
        top: 100px;
    }
</style>
