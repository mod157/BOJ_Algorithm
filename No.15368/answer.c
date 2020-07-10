#include <cstdio>
int n, par[200002], cnt[200002];
long long ans[200002];
int main() {
    scanf("%d", &n);
    for (int i = 2; i <= n; i++) scanf("%d", &par[i]);
    for (int i = n; i >= 1; i--) {
        ans[par[i]] += ++ans[i] + ++cnt[i];
        cnt[par[i]] += cnt[i];
    }
    for (int i = 1; i <= n; i++) printf("%lld ", ans[i]);
    return 0;
}