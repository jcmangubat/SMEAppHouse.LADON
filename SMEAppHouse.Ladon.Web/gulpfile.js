// Run : npx gulp

const gulp = require('gulp');
const cleanCSS = require('gulp-clean-css');
const uglify = require('gulp-uglify');
const concat = require('gulp-concat');
const rename = require('gulp-rename');

/* CSS -------------------------------- */

// Minify common CSS file
gulp.task('minify-common-css', () => {
    return gulp.src('wwwroot/css/common.css')
        .pipe(concat('common.css'))
        .pipe(rename({ suffix: '.min' }))
        .pipe(cleanCSS())
        .pipe(gulp.dest('wwwroot/css/dist'));
});

// Minify site CSS files
gulp.task('minify-index-css', () => {
    return gulp.src([
        'wwwroot/css/carousel.css',
        'wwwroot/css/feature.css',
        'wwwroot/css/welcome.css',
        'wwwroot/css/about.css',
        'wwwroot/css/fact.css',
        'wwwroot/css/service.css',
        'wwwroot/css/video.css',
        'wwwroot/css/team.css',
        'wwwroot/css/faq.css',
        'wwwroot/css/testimonial.css',
        'wwwroot/css/blog.css',
        'wwwroot/css/contact.css',
        'wwwroot/css/projects.css',
        'wwwroot/css/site.css',
    ])
        .pipe(concat('styles.css')) // Concatenate to a single file
        .pipe(rename({ suffix: '.min' }))
        .pipe(cleanCSS())
        .pipe(gulp.dest('wwwroot/css/dist'));
});

// Minify articles CSS files
gulp.task('minify-articles-css', () => {
    return gulp.src('wwwroot/css/articles.css')
        .pipe(concat('articles.css'))
        .pipe(rename({ suffix: '.min' }))
        .pipe(cleanCSS())
        .pipe(gulp.dest('wwwroot/css/dist'));
});

// Minify article CSS files
gulp.task('minify-article-css', () => {
    return gulp.src('wwwroot/css/article.css')
        .pipe(concat('article.css'))
        .pipe(rename({ suffix: '.min' }))
        .pipe(cleanCSS())
        .pipe(gulp.dest('wwwroot/css/dist'));
});

// Minify feature project page CSS files
gulp.task('minify-featureproject-css', () => {
    return gulp.src('wwwroot/css/featureproject.css')
        .pipe(concat('featureproject.css'))
        .pipe(rename({ suffix: '.min' }))
        .pipe(cleanCSS())
        .pipe(gulp.dest('wwwroot/css/dist'));
});

// Minify user-auth CSS files
gulp.task('minify-user-auth-css', () => {
    return gulp.src('wwwroot/css/user-auth.css')
        .pipe(concat('login.css'))
        .pipe(rename({ suffix: '.min' }))
        .pipe(cleanCSS())
        .pipe(gulp.dest('wwwroot/css/dist'));
});

/* JS -------------------------------- */

// Minify common.js
gulp.task('minify-common-js', () => {
    return gulp.src('wwwroot/js/common.js')
        .pipe(rename({ suffix: '.min' }))
        .pipe(uglify())
        .pipe(gulp.dest('wwwroot/js/dist'));
});

// Minify index page js
gulp.task('minify-index-js', () => {
    return gulp.src('wwwroot/js/site.js')
        .pipe(rename({ suffix: '.min' }))
        .pipe(uglify())
        .pipe(gulp.dest('wwwroot/js/dist'));
});

// Minify article.js
gulp.task('minify-article-js', () => {
    return gulp.src('wwwroot/js/article.js')
        .pipe(rename({ suffix: '.min' }))
        .pipe(uglify())
        .pipe(gulp.dest('wwwroot/js/dist'));
});

// Minify quoterequest.js
gulp.task('minify-quoterequest-js', () => {
    return gulp.src('wwwroot/js/quoterequest.js')
        .pipe(rename({ suffix: '.min' }))
        .pipe(uglify())
        .pipe(gulp.dest('wwwroot/js/dist'));
});

// Minify featureproject.js
gulp.task('minify-featureproject-js', () => {
    return gulp.src('wwwroot/js/featureproject.js')
        .pipe(rename({ suffix: '.min' }))
        .pipe(uglify())
        .pipe(gulp.dest('wwwroot/js/dist'));
});

// Default task
gulp.task('default',
    gulp.parallel(
        'minify-common-css',
        'minify-index-css',
        'minify-articles-css',
        'minify-article-css',
        'minify-featureproject-css',
        'minify-user-auth-css',
        'minify-common-js',
        'minify-index-js',
        'minify-article-js',
        'minify-quoterequest-js',
        'minify-featureproject-js',
    ));