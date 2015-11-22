module.exports = function (grunt) {
    var NODE_MODULES_DIR = 'node_modules/';
    var SRC_DIR = 'src/';
    var PUBLISH_DIR = 'dist/';

    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),

        clean: {
            prebuild: {
                src: [SRC_DIR + 'scripts/vendor/', SRC_DIR + 'styles/vendor/']
            }
        },
        copy: {
            vendorjs: {
                cwd: NODE_MODULES_DIR,
                src: [
                    'angular/angular.min.js',
                    'angular-animate/angular-animate.min.js',
                    'angular-aria/angular-aria.min.js',
                    'angular-material/angular-material.min.js',
                    'angular-translate/dist/angular-translate.min.js',
                    'angular-translate/dist/angular-translate-loader-partial/angular-translate-loader-partial.min.js'
                ],
                dest: SRC_DIR + 'scripts/vendor/',
                expand: true,
                flatten: true
            },
            vendorspec: {
                cwd: NODE_MODULES_DIR,
                src: [
                    'angular-mocks/angular-mocks.js'
                ],
                dest: SRC_DIR + 'scripts/vendor/spec/',
                expand: true,
                flatten: true
            },
            vendorcss: {
                cwd: NODE_MODULES_DIR,
                src: [
                    'angular-material/angular-material.min.css'
                ],
                dest: SRC_DIR + 'styles/vendor/',
                expand: true,
                flatten: true
            },
            publish: {
                cwd: SRC_DIR,
                src: ['**', '!scripts/com/**/*.js', '!scripts/spec/**/*.js', '!scripts/e2e/**/*.js', '!styles/less/**'],
                dest: PUBLISH_DIR,
                expand: true
            }
        },
        concat: {
            options: {
                separator: ';'
            },
            buildjs: {
                src: [
                    SRC_DIR + 'scripts/com/app.js',
                    SRC_DIR + 'scripts/com/config.js',
                    SRC_DIR + 'scripts/com/**/*.js'
                ],
                dest: SRC_DIR + 'scripts/main.js'
            }
        },
        jshint: {
            all: [
                'Gruntfile.js',
                SRC_DIR + 'scripts/com/**/*.js',
                SRC_DIR + 'scripts/e2e/**/*.js',
                SRC_DIR + 'scripts/spec/**/*.js'
            ],
            options: {
                reporter: require('jshint-stylish'),
                globals: {
                    angular: true
                }
            }
        },
        less: {
            development: {
                options: {
                    cleancss: true
                },
                files: {
                    'src/styles/main.css': 'src/styles/less/**/*.less'
                }
            }
        },
        jasmine: {
            module: {
                src: 'src/scripts/com/**/*.js',
                options: {
                    specs: 'src/scripts/spec/**/*Spec.js',
                    vendor: [
                        'src/scripts/vendor/angular.min.js',
                        'src/scripts/vendor/angular-animates.min.js',
                        'src/scripts/vendor/angular-aria.min.js',
                        'src/scripts/vendor/angular-material.min.js',
                        'src/scripts/vendor/angular-translate.min.js',
                        'src/scripts/vendor/angular-translate-loader-partial.min.js',
                        'src/scripts/vendor/spec/angular-mocks.js'
                    ],
                    helpers: 'src/scripts/spec/helper/*.js'
                }
            }
        },
        protractor: {
            options: {
                configFile: 'protractor.conf.js',
                keepAlive: false,
                noColor: false
            },
            your_target: {}
        }
    });

    grunt.loadNpmTasks('grunt-contrib-jshint');
    // grunt.loadNpmTasks('grunt-contrib-less');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-clean');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-jasmine');
    // grunt.loadNpmTasks('grunt-protractor-runner');

    // grunt.registerTask('default', ['jshint', 'jasmine', 'clean', 'less', 'concat', 'copy']);
    grunt.registerTask('pre-build', ['clean:prebuild', 'copy:vendorjs', 'copy:vendorcss']);
    grunt.registerTask('pre-test', ['copy:vendorspec']);
    grunt.registerTask('unit-test', ['pre-build', 'jshint', 'pre-test', 'jasmine']);
    grunt.registerTask('build', ['pre-build', 'jshint', 'pre-test', 'jasmine', 'concat:buildjs']);
    // grunt.registerTask('e2e-test', ['jshint', 'jasmine', 'clean', 'less', 'concat', 'protractor']);
};
