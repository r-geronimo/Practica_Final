﻿@page
@model Practica_Final.Pages.Dashboard.Transferencias.IndexModel
@{
    ViewData["Title"] = "Transferencias";
}

<div class="main-wrapper main-wrapper-1">
    <div class="navbar-bg"></div>
    <nav class="navbar navbar-expand-lg main-navbar sticky">
        <div class="form-inline mr-auto">
            <ul class="navbar-nav mr-3">
                <li>
                    <a href="#" data-toggle="sidebar" class="nav-link nav-link-lg
                                  collapse-btn"> <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-align-justify"><line x1="21" y1="10" x2="3" y2="10"></line><line x1="21" y1="6" x2="3" y2="6"></line><line x1="21" y1="14" x2="3" y2="14"></line><line x1="21" y1="18" x2="3" y2="18"></line></svg></a>
                </li>
                <li>
                    <a href="#" class="nav-link nav-link-lg fullscreen-btn">
                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-maximize"><path d="M8 3H5a2 2 0 0 0-2 2v3m18 0V5a2 2 0 0 0-2-2h-3m0 18h3a2 2 0 0 0 2-2v-3M3 16v3a2 2 0 0 0 2 2h3"></path></svg>
                    </a>
                </li>

            </ul>
        </div>
        <ul class="navbar-nav navbar-right">

            <li class="dropdown">
                <a href="#" data-toggle="dropdown" class="nav-link dropdown-toggle nav-link-lg nav-link-user" aria-expanded="false"> <img alt="image" src="assets/img/user.png" class="user-img-radious-style"> <span class="d-sm-none d-lg-inline-block"></span></a>
                <div class="dropdown-menu dropdown-menu-right pullDown">
                    <div class="dropdown-title">Hola @User.Identity.Name</div>
                    <a href="profile.html" class="dropdown-item has-icon">
                        <i class="far
                                      fa-user"></i> Profile
                    </a>  <a href="#" class="dropdown-item has-icon">
                        <i class="fas fa-cog"></i>
                        Settings
                    </a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item has-icon text-danger" asp-area="" asp-page="/Logout">
                        <i class="fas fa-sign-out-alt"></i>
                        Cerrar sesión
                    </a>
                </div>
            </li>
        </ul>
    </nav>
    <div class="main-sidebar sidebar-style-2" tabindex="1" style="overflow: hidden; outline: none;">
        <aside id="sidebar-wrapper">
            <div class="sidebar-brand">
                <a href="index.html">
                    Netbanking
                </a>
            </div>
            <ul class="sidebar-menu">
                <li class="menu-header">Main</li>
                <li class="dropdown">
                    <a href="/Dashboard" class="nav-link toggled"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-monitor"><rect x="2" y="3" width="20" height="14" rx="2" ry="2"></rect><line x1="8" y1="21" x2="16" y2="21"></line><line x1="12" y1="17" x2="12" y2="21"></line></svg><span>Dashboard</span></a>
                </li>
                <li class="dropdown active">
                    <a href="/Dashboard/Transferencias" class="nav-link toggled"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-monitor"><rect x="2" y="3" width="20" height="14" rx="2" ry="2"></rect><line x1="8" y1="21" x2="16" y2="21"></line><line x1="12" y1="17" x2="12" y2="21"></line></svg><span>Transferencias</span></a>
                </li>
                <li class="dropdown">
                    <a href="/Dashboard/Cuentas" class="nav-link toggled"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-monitor"><rect x="2" y="3" width="20" height="14" rx="2" ry="2"></rect><line x1="8" y1="21" x2="16" y2="21"></line><line x1="12" y1="17" x2="12" y2="21"></line></svg><span>Histórico de transacciones</span></a>
                </li>
                <li class="dropdown">
                    <a href="/Dashboard/TipoCuentas" class="nav-link toggled"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-monitor"><rect x="2" y="3" width="20" height="14" rx="2" ry="2"></rect><line x1="8" y1="21" x2="16" y2="21"></line><line x1="12" y1="17" x2="12" y2="21"></line></svg><span>Histórico de transacciones</span></a>
                </li>
                <li class="dropdown">
                    <a href="/Dashboard/Transacciones" class="nav-link toggled"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-monitor"><rect x="2" y="3" width="20" height="14" rx="2" ry="2"></rect><line x1="8" y1="21" x2="16" y2="21"></line><line x1="12" y1="17" x2="12" y2="21"></line></svg><span>Histórico de transacciones</span></a>
                </li>
            </ul>
        </aside>
    </div>
    <!-- Main Content -->
    <div class="main-content" style="min-height: 239px;">
        <section class="section">

            <form action="">
                <label for="trasferencias">Selecciona el tipos de transancion:</label>
                <select name="trasferencias" id="trasferencias">
                    <option value="Terceros">Terceros</option>
                    <option value="Entre tus cuentas">Entre tus cuentas</option>
                    <option value="Entre otros bancos">Entre otros bancos</option>
                    <option value="Empresas">Empresas</option>
                    <option value="Cuentas prepagas virtuales">Cuentas prepagas virtuales</option>
                    <option value="Cuentas prepagas virtuales expresas">Cuentas prepagas virtuales expresas</option>
                </select>
                <br><br>

                <label for="trasferencias">Selecciona el tipos de cuenta:</label>
                <select name="trasferencias" id="trasferencias">
                    <option value="ahorros">Cuenta de ahorros</option>
                    <option value="nomina">Cuenta nomina</option>
                    <option value="corriente">Cuenta corriente</option>
                </select>

                <br><br>
                <label>Cuenta de destino</label><br>
                <input type="text" id="destino" name="destino">
                <br><br>
                <label>Fecha de la Transferencia</label><br>
                <input type="text" id="fecha" name="fecha">
                <br><br>
                <label>Via de pago</label><br>
                <input type="text" id="destino" name="destino">
                <br><br>
                <label>
                    Monto:<br><br>
                    <label>
                        RD$:
                        <input type="text" id="debito" name="debito">
                        <br><br>
                        <input type="submit" value="Submit">
            </form>
        </section>

    </div>
    <footer class="main-footer">
        <div class="footer-left">
            <a href="templateshub.net">Templateshub</a>
        </div>
        <div class="footer-right">
        </div>
    </footer>
</div>