<template>
    <div class="modal" tabindex="-1" role="dialog" id="addEmp">
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
                            <input type="text" v-model="empCode" class="form-control" placeholder="Mã nhân viên" />
                        </div>

                        <div class="form-group">
                            <input type="text" v-model="empName" class="form-control" placeholder="Tên nhân viên" />
                        </div>

                        <div class="form-group">
                            <input type="text" v-model.number="empAge" class="form-control" placeholder="Tuổi" />
                        </div>

                        <div class="form-group">
                            <input type="text" v-model="empGender" class="form-control" placeholder="Giới tính" />
                        </div>

                        <div class="form-group">
                            <input type="text" v-model="empPhone" class="form-control" placeholder="Số điện thoại" />
                        </div>

                        <div class="form-group">
                            <input type="text" v-model="empAddress" class="form-control" placeholder="Quê quán" />
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

        //props: ['age'],

        data() {
            return {
                listEmployees: [],

                empCode: "",

                empName: "",

                empAge: null,

                empGender: "",

                empPhone: "",

                empAddress: "",
            };
        },

        methods: {
            getModalData() {
                var eCode = this.empCode;

                var eName = this.empName;

                var eAge = this.empAge;

                var eGender = this.empGender;

                var ePhone = this.empPhone;

                var eAddress = this.empAddress;

                var employee = {
                    employeeCode: eCode,

                    employeeName: eName,

                    age: eAge,

                    gender: eGender,

                    phone: ePhone,

                    address: eAddress,
                };

                this.$emit("getEmp", employee);
            },
        },
    };
</script>

<style scoped>
    .modal-dialog {
        top: 100px;
    }
</style>
